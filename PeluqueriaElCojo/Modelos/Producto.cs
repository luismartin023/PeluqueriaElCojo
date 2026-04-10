using PeluqueriaElCojo.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Modelos
{
    public class Producto : IEquatable<Producto>, ICloneable
    {
        [Requerido]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        // IEquatable: Detectar duplicados por código
        public bool Equals(Producto other)
        {
            if (other == null) return false;
            return this.Codigo == other.Codigo;
        }

        // ICloneable: Duplicar un registro
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
