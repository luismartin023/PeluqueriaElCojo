using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Utilidades
{
    public static class GeneradorReportes
    {
        // Método genérico para listar cualquier cosa (Clientes, Empleados, etc.)
        public static string GenerarLista<T>(List<T> items, string titulo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- " + titulo.ToUpper() + " ---");
            foreach (var item in items)
            {
                sb.AppendLine("- " + item.ToString());
            }
            return sb.ToString();
        }
    }
}
