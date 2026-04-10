using PeluqueriaElCojo.Atributos;
using System;

namespace PeluqueriaElCojo.Modelos
{
    // Agregamos IFacturable para habilitar el Polimorfismo en la factura
    public class Producto : IFacturable, IEquatable<Producto>, ICloneable
    {
        [Requerido]
        public string Codigo { get; set; }

        [Requerido]
        public string Nombre { get; set; }

        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Stock { get; set; }

        // Implementación obligatoria de IFacturable
        public decimal CalcularPrecio() => Precio;
        public string GeneralLineraRecibo() => string.Format("{0,-20} RD${1:N0}", Nombre, Precio);

        public bool Equals(Producto other)
        {
            if (other == null) return false;
            return this.Codigo == other.Codigo;
        }

        public override bool Equals(object obj) => Equals(obj as Producto);
        public override int GetHashCode() => Codigo != null ? Codigo.GetHashCode() : 0;

        public object Clone() => this.MemberwiseClone();

        public decimal CalcularGanancia() => Precio - Costo;

        public override string ToString() => string.Format("[Producto] {0} - RD${1:N0}", Nombre, Precio);
    }
}




