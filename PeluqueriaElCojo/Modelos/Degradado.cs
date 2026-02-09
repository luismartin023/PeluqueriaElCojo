namespace PeluqueriaElCojo.Modelos
{
    public class Degradado : Servicio
    {
        public int NivelComplejidad { get; set; }

        public Degradado(int nivel) : base("Degradado", 200, 35)
        {
            NivelComplejidad = nivel;
        }
        public Degradado() : this(1) { }

        public override decimal CalcularPrecio()
        {
            return PrecioBase + (NivelComplejidad * 50);
        }

        public override string GeneralLineraRecibo()
        {
            string txt = "Degradado (Nv." + NivelComplejidad + ")";
            return string.Format("{0,-20} RD${1:N0}", txt, CalcularPrecio());
        }
    }
}
