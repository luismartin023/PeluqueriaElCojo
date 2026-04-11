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
        private List<Empleado> _empleados = new List<Empleado>();
        private Cliente _clienteActual = null;

        public FormVenta()
        {
            InitializeComponent();

            // Solo números en el teléfono, máx 10 dígitos
            txtTelefono.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;

                if (char.IsDigit(e.KeyChar) && txtTelefono.Text.Length >= 10)
                    e.Handled = true;
            };

            // Nombre: solo letras y espacios, sin números
            txtNombre.KeyPress += (s, e) =>
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            };
        }



        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Validación previa de entrada para evitar que el constructor lance excepción
            string nombre = txtNombre.Text ?? string.Empty;
            string rawTel = txtTelefono.Text ?? string.Empty;
            string limpio = rawTel.Replace(" ", "").Replace("-", "").Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(limpio))
            {
                MessageBox.Show("Ingrese un teléfono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (char c in limpio)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("El teléfono solo debe contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (limpio.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener exactamente 10 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Crear la instancia del modelo
            Cliente nuevoCliente = new Cliente(nombre, txtTelefono.Text);

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
            if (clbItems.CheckedItems.Count == 0) { MessageBox.Show("Selecciona servicios o productos"); return; }

            // Usamos una lista de la interfaz para aprovechar el Polimorfismo
            List<IFacturable> itemsFactura = new List<IFacturable>();
            foreach (var item in clbItems.CheckedItems)
            {
                itemsFactura.Add((IFacturable)item);
            }

            decimal total = CalcularTotalItems(itemsFactura);
            _clienteActual.RegistrarVisita();

            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    // Guardar cabecera de factura
                    string qFact = "INSERT INTO Facturas (ClienteId, Total, Fecha) VALUES (@cid, @total, @f); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(qFact, conn);
                    cmd.Parameters.AddWithValue("@cid", _clienteActual.Id);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@f", DateTime.Now);
                    int facturaId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Guardar detalles polimórficamente
                    foreach (var item in itemsFactura)
                    {
                        string qDet = "INSERT INTO DetalleFactura (FacturaId, ServicioNombre, Precio) VALUES (@fid, @nom, @pre)";
                        SqlCommand cmdDet = new SqlCommand(qDet, conn);
                        cmdDet.Parameters.AddWithValue("@fid", facturaId);
                        cmdDet.Parameters.AddWithValue("@nom", item.ToString());
                        cmdDet.Parameters.AddWithValue("@pre", item.CalcularPrecio());
                        cmdDet.ExecuteNonQuery();
                    }
                }
                txtRecibo.Text = GenerarReciboDinamico(itemsFactura);
                lblTotal.Text = string.Format("TOTAL: RD${0:N2}", total);

                // Llamamos a limpiar para que la UI quede lista para otro cobro
                LimpiarChecks();
                MessageBox.Show("¡Venta procesada con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
                _clienteActual = _clientes[lstClientes.SelectedIndex];
        }

        private decimal CalcularTotalItems(List<IFacturable> items)
        {
            decimal sub = 0;
            foreach (var item in items) 
            {
                // Polimorfismo en acción: cada item sabe su propio precio
                sub += item.CalcularPrecio();
            }
            // Cálculo de total aplicando descuento y el 18% de ITBIS requerido
            return sub * (1 - _clienteActual.ObtenerDescuento()) * 1.18m;
        }

        private string GenerarReciboDinamico(List<IFacturable> itemsParaRecibo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("╔═══════════════════════════════╗");
            sb.AppendLine("║    PELUQUERÍA EL COJO         ║");
            sb.AppendLine("║    Villa Mella, Sto. Domingo  ║");
            sb.AppendLine("╠═══════════════════════════════╣");
            sb.AppendLine(string.Format("║ Cliente: {0,-20}║", _clienteActual.Nombre));
            sb.AppendLine(string.Format("║ Tipo: {0,-23}║", _clienteActual.Tipo));
            sb.AppendLine("╠═══════════════════════════════╣");

            decimal subtotalSimple = 0;
            foreach (var item in itemsParaRecibo)
            {
                // Polimorfismo: cada item sabe cómo generar su línea de recibo
                sb.AppendLine(string.Format("║  {0,-27}║", item.GeneralLineraRecibo()));
                subtotalSimple += item.CalcularPrecio();
            }

            decimal desc = _clienteActual.ObtenerDescuento();
            decimal baseI = subtotalSimple * (1 - desc);

            sb.AppendLine("╠═══════════════════════════════╣");
            sb.AppendLine(string.Format("║ Subtotal:        RD${0,8:N0} ║", subtotalSimple));
            if (desc > 0)
                sb.AppendLine(string.Format("║ Descuento ({0}%): -RD${1,6:N0} ║", desc * 100, subtotalSimple * desc));

            sb.AppendLine(string.Format("║ ITBIS (18%):      RD${0,7:N0} ║", baseI * 0.18m));
            sb.AppendLine("╠═══════════════════════════════╣");
            sb.AppendLine(string.Format("║ TOTAL:           RD${0,8:N0} ║", baseI * 1.18m));
            sb.AppendLine("╚═══════════════════════════════╝");
            sb.AppendLine("      ¡Gracias por su visita!");
            return sb.ToString();
        }

        private void LimpiarChecks()
        {
            // Desmarcamos todos los items de la lista CheckedListBox
            for (int i = 0; i < clbItems.Items.Count; i++)
            {
                clbItems.SetItemChecked(i, false);
            }
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            RefrescarCatalogo();
        }

        private void numNivel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            if (_empleados.Count == 0)
            {
                MessageBox.Show("No hay empleados registrados para mostrar el ranking.");
                return;
            }

            // la lógica de comparación que pusimos en la clase Empleado.
            _empleados.Sort();

            // para generar el texto del reporte.
            string reporte = GeneradorReportes.GenerarLista(_empleados, "Ranking de Barberos por Ventas");

            MessageBox.Show(reporte, "Ranking de Ventas");
        }

        private void btnGestionarInventario_Click(object sender, EventArgs e)
        {
            FormInventario frm = new FormInventario();
            frm.ShowDialog();
            RefrescarCatalogo(); // Recargamos la lista después de crear productos
        }

        private void CargarEmpleadosDesdeSQL()
        {
            _empleados.Clear();
            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    string query = "SELECT Id, Nombre, Apodo, SueldoBase FROM Empleados";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        _empleados.Add(new Empleado
                        {
                            Id = (int)r["Id"],
                            Nombre = r["Nombre"].ToString(),
                            Apodo = r["Apodo"].ToString(),
                            SueldoBase = Convert.ToDecimal(r["SueldoBase"]),
                            VentasAcumuladas = 0 // En una versión pro, aquí sumarías sus facturas
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar barberos: " + ex.Message);
            }
        }

        private void RefrescarCatalogo()
        {
            clbItems.Items.Clear();
            // Agregamos Servicios (Herencia)
            clbItems.Items.Add(new CorteNormal());
            clbItems.Items.Add(new Afeitado(false));
            clbItems.Items.Add(new Degradado(1));
            clbItems.Items.Add(new CorteCejas());

            // Agregamos Productos desde SQL
            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    string q = "SELECT Codigo, Nombre, Precio, Stock FROM Productos";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        clbItems.Items.Add(new Producto
                        {
                            Codigo = r["Codigo"].ToString(),
                            Nombre = r["Nombre"].ToString(),
                            Precio = (decimal)r["Precio"],
                            Stock = (int)r["Stock"]
                        });
                    }
                }
            }
            catch { /* Manejar error silenciosamente */ }
        }


        private void clbItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRecibo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarBarbero_Click(object sender, EventArgs e)
        {
            FormEmpleados frm = new FormEmpleados();
            frm.ShowDialog();
            CargarEmpleadosDesdeSQL(); // Actualiza la lista después de registrar
        }

    }
}

