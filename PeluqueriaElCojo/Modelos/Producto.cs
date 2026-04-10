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

        [Requerido]
        public string Nombre { get; set; }

        public string Categoria { get; set; } 
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }    // Requerido para calcular ganancia
        public int Stock { get; set; }

        // IEquatable: Detección de duplicados
        public bool Equals(Producto other)
        {
            if (other == null) return false;
            return this.Codigo == other.Codigo;
        }

        // Requerimiento Rúbrica: Sobrescribir Equals(object) y GetHashCode
        public override bool Equals(object obj) => Equals(obj as Producto);
        public override int GetHashCode() => Codigo != null ? Codigo.GetHashCode() : 0;

        // ICloneable: Duplicar registro
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // Método para cumplir con el requisito de "Calcular ganancia"
        public decimal CalcularGanancia() => Precio - Costo;

        public override string ToString()
        {
            return string.Format("[{0}] {1} - RD${2:N2} (Stock: {3})", Codigo, Nombre, Precio, Stock);
        }
    }
}
