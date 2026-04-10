using System.Data.SqlClient;

namespace PeluqueriaElCojo.Utilidades
{
    public static class ConexionDB
    {
        private static string cadena = "Data Source=.;Initial Catalog=PeluqueriaElCojo;Integrated Security=True";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();
            return conn;
        }
    }
}
