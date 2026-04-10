using PeluqueriaElCojo.Modelos;
using PeluqueriaElCojo.Utilidades;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PeluqueriaElCojo
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado
            {
                Nombre = txtNombre.Text,
                Apodo = txtApodo.Text,
                Cedula = txtCedula.Text,
                SueldoBase = numSueldoBase.Value,
                VentasAcumuladas = 0 // Empieza en cero
            };

            // Validación por Reflection (Punto obligatorio)
            var errores = Validador.Validar(emp);
            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores));
                return;
            }

            try
            {
                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    string query = "INSERT INTO Empleados (Nombre, Apodo, Cedula, SueldoBase, ComisionPorcentaje) VALUES (@n, @a, @c, @s, @cp)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@n", emp.Nombre);
                    cmd.Parameters.AddWithValue("@a", emp.Apodo);
                    cmd.Parameters.AddWithValue("@c", emp.Cedula);
                    cmd.Parameters.AddWithValue("@s", emp.SueldoBase);
                    cmd.Parameters.AddWithValue("@cp", 10); // Ejemplo: 10% de comisión
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("¡Barbero registrado!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message);
            }
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
