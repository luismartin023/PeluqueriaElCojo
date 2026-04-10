using PeluqueriaElCojo.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Modelos
{
    public class Empleado : IComparable<Empleado>
    {
        public int Id { get; set; }

        [Requerido] // Punto: Atributos Personalizados
        public string Nombre { get; set; }

        public string Apodo { get; set; }
        public string Cedula { get; set; }

        // Esta es la propiedad que te faltaba y causaba el error
        public decimal SueldoBase { get; set; }

        public decimal VentasAcumuladas { get; set; }

        // IComparable: Requerido para el Ranking
        public int CompareTo(Empleado other)
        {
            if (other == null) return 1;
            // Ordenar de mayor a menor venta
            return other.VentasAcumuladas.CompareTo(this.VentasAcumuladas);
        }

        public override string ToString()
        {
            return string.Format("{0} - Total Ventas: RD${1:N0}", Apodo, VentasAcumuladas);
        }
    }
}
