using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PeluqueriaElCojo
{
    public partial class FormVenta : Form
    {

        private List<Cliente> _clientes = new List<Cliente>();
        private List<Servicio> _servicios = new List<Servicio>();
        private Cliente _clienteActual = null;

        public FormVenta()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // 1. Crear la instancia del modelo
            Cliente nuevoCliente = new Cliente(txtNombre.Text, txtTelefono.Text);

            // 2. Validar usando Reflection (Punto clave de la Unidad 3)
            List<string> errores = Validador.Validar(nuevoCliente);

            if (errores.Count > 0)
            {
                // Si hay errores de validación, los mostramos y detenemos el proceso
                MessageBox.Show("Errores encontrados:\n" + string.Join("\n", errores), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Si es válido, guardar en SQL Server
            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    string query = "INSERT INTO Clientes (Nombre, Telefono, Visitas, Tipo) VALUES (@nom, @tel, @vis, @tipo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", nuevoCliente.Nombre);
                    cmd.Parameters.AddWithValue("@tel", nuevoCliente.Telefono);
                    cmd.Parameters.AddWithValue("@vis", nuevoCliente.Visitas);
                    cmd.Parameters.AddWithValue("@tipo", nuevoCliente.Tipo.ToString());
                    cmd.ExecuteNonQuery();
                }

                // 4. Actualizar la UI local
                _clientes.Add(nuevoCliente);
                lstClientes.Items.Add(nuevoCliente);
                txtNombre.Clear();
                txtTelefono.Clear();
                MessageBox.Show("Cliente guardado correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en SQL: " + ex.Message);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_clienteActual == null) { MessageBox.Show("Selecciona cliente"); return; }

            _servicios.Clear();
            if (chkCorteNormal.Checked) _servicios.Add(new CorteNormal());
            if (chkDegradado.Checked) _servicios.Add(new Degradado((int)numNivel.Value));
            if (chkAfeitado.Checked) _servicios.Add(new Afeitado(chkToalla.Checked));
            if (chkCejas.Checked) _servicios.Add(new CorteCejas());

            if (_servicios.Count == 0) { MessageBox.Show("Selecciona servicios"); return; }

            decimal total = CalcularTotal();
            _clienteActual.RegistrarVisita();

            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    // 1. Insertar la Factura y obtener su ID
                    string queryFactura = @"INSERT INTO Facturas (ClienteId, Total, Fecha) 
                                   VALUES (@cid, @total, @fecha); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdFact = new SqlCommand(queryFactura, conn);
                    cmdFact.Parameters.AddWithValue("@cid", _clienteActual.Id);
                    cmdFact.Parameters.AddWithValue("@total", total);
                    cmdFact.Parameters.AddWithValue("@fecha", DateTime.Now);

                    int facturaId = Convert.ToInt32(cmdFact.ExecuteScalar());

                    // 2. Insertar cada servicio en el detalle (Polimorfismo en acción)
                    foreach (Servicio s in _servicios)
                    {
                        string queryDetalle = "INSERT INTO DetalleFactura (FacturaId, ServicioNombre, Precio) VALUES (@fid, @nom, @pre)";
                        SqlCommand cmdDet = new SqlCommand(queryDetalle, conn);
                        cmdDet.Parameters.AddWithValue("@fid", facturaId);
                        cmdDet.Parameters.AddWithValue("@nom", s.Nombre);
                        cmdDet.Parameters.AddWithValue("@pre", s.CalcularPrecio());
                        cmdDet.ExecuteNonQuery();
                    }

                    // 3. Actualizar visitas del cliente en SQL
                    string queryUpdate = "UPDATE Clientes SET Visitas = @vis, Tipo = @tipo WHERE Nombre = @nom";
                    SqlCommand cmdUpd = new SqlCommand(queryUpdate, conn);
                    cmdUpd.Parameters.AddWithValue("@vis", _clienteActual.Visitas);
                    cmdUpd.Parameters.AddWithValue("@tipo", _clienteActual.Tipo.ToString());
                    cmdUpd.Parameters.AddWithValue("@nom", _clienteActual.Nombre);
                    cmdUpd.ExecuteNonQuery();
                }

                // Actualizar UI
                lstClientes.Items[lstClientes.SelectedIndex] = _clienteActual;
                txtRecibo.Text = GenerarRecibo();
                lblTotal.Text = string.Format("TOTAL: RD${0:N2}", total);
                LimpiarChecks();
                MessageBox.Show("Venta procesada y guardada en SQL.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar cobro: " + ex.Message);
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteActual = _clientes[lstClientes.SelectedIndex];
        }

        private decimal CalcularTotal()
        {
            decimal sub = 0;
            foreach (Servicio s in _servicios)
                sub += s.CalcularPrecio();
            return sub * (1 - _clienteActual.ObtenerDescuento()) * 1.18m;
        }

        private string GenerarRecibo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔═══════════════════════════════╗");
            sb.AppendLine("║    PELUQUERÍA EL COJO         ║");
            sb.AppendLine("║    Villa Mella, Sto. Domingo  ║");
            sb.AppendLine("╠═══════════════════════════════╣");
            sb.AppendLine(string.Format("║ Cliente: {0,-20}║", _clienteActual.Nombre));
            sb.AppendLine(string.Format("║ Tipo: {0,-23}║", _clienteActual.Tipo));
            sb.AppendLine("╠═══════════════════════════════╣");

            decimal sub = 0;
            foreach (Servicio s in _servicios)
            {
                sb.AppendLine(string.Format("║  {0,-27}║", s.GeneralLineraRecibo()));
                sub += s.CalcularPrecio();
            }

            sb.AppendLine("╠═══════════════════════════════╣");
            sb.AppendLine(string.Format("║ Subtotal:        RD${0,8:N0} ║", sub));

            decimal desc = _clienteActual.ObtenerDescuento();
            if (desc > 0)
                sb.AppendLine(string.Format("║ Descuento ({0}%): -RD${1,6:N0} ║", desc * 100, sub * desc));

            decimal baseI = sub * (1 - desc);
            sb.AppendLine(string.Format("║ ITBIS (18%):      RD${0,7:N0} ║", baseI * 0.18m));
            sb.AppendLine("╠═══════════════════════════════╣");
            sb.AppendLine(string.Format("║ TOTAL:           RD${0,8:N0} ║", baseI * 1.18m));
            sb.AppendLine("╚═══════════════════════════════╝");
            sb.AppendLine("      ¡Gracias por su visita!");
            return sb.ToString();
        }

        private void LimpiarChecks()
        {
            chkCorteNormal.Checked = false;
            chkDegradado.Checked = false;
            chkAfeitado.Checked = false;
            chkToalla.Checked = false;
            chkCejas.Checked = false;
            numNivel.Value = 1;
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

        }

        private void numNivel_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

