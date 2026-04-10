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
        [Requerido]
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Cedula { get; set; }
        public decimal VentasAcumuladas { get; set; }

        // Implementación de IComparable para ordenar por ventas
        public int CompareTo(Empleado other)
        {
            if (other == null) return 1;
            // Orden descendente (de mayor a menor venta)
            return other.VentasAcumuladas.CompareTo(this.VentasAcumuladas);
        }

        public override string ToString()
        {
            return string.Format("{0} - Ventas: RD${1:N2}", Apodo, VentasAcumuladas);
        }
    }
}
