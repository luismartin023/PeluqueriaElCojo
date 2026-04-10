using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;
using System.Data.SqlClient;

namespace PeluqueriaElCojo
{
    public partial class FormInventario : Form
    {
        private List<Producto> _tempInventario = new List<Producto>();

        public FormInventario()
        {
            InitializeComponent();

            // Código: solo letras, números y guiones (sin espacios ni símbolos raros)
            txtCodigo.KeyPress += (s, e) =>
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            };

            // Nombre del producto: solo letras y espacios
            txtNombre.KeyPress += (s, e) =>
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            };

            // Categoría: solo letras y espacios
            txtCategoria.KeyPress += (s, e) =>
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            };

        }


        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click_1(object sender, EventArgs e)
        {
            {
                // 1. Crear el objeto con los datos de la interfaz
                Producto p = new Producto
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Categoria = txtCategoria.Text,
                    Precio = numPrecio.Value,
                    Costo = numCosto.Value,
                    Stock = (int)numStock.Value
                };

                // 2. Validación dinámica usando Reflection (Punto obligatorio)
                var errores = Validador.Validar(p);
                if (errores.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", errores), "Error de Validación");
                    return;
                }

                // 3. Guardar en la Base de Datos SQL
                try
                {
                    using (SqlConnection conn = ConexionDB.ObtenerConexion())
                    {
                        // Primero verificamos duplicados con una consulta rápida
                        string checkQuery = "SELECT COUNT(*) FROM Productos WHERE Codigo = @c";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@c", p.Codigo);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Ya existe un producto con este código.");
                            return;
                        }

                        string query = "INSERT INTO Productos (Codigo, Nombre, Categoria, Precio, Costo, Stock) VALUES (@c, @n, @cat, @p, @cos, @s)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@c", p.Codigo);
                        cmd.Parameters.AddWithValue("@n", p.Nombre);
                        cmd.Parameters.AddWithValue("@cat", p.Categoria);
                        cmd.Parameters.AddWithValue("@p", p.Precio);
                        cmd.Parameters.AddWithValue("@cos", p.Costo);
                        cmd.Parameters.AddWithValue("@s", p.Stock);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto registrado exitosamente.");
                    this.DialogResult = DialogResult.OK; // Indica que se guardó algo para refrescar la lista
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }

        }
    }
}

    
