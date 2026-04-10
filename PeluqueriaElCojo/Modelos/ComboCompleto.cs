namespace PeluqueriaElCojo.Modelos
{
    public class ComboCompleto : Servicio
    {
        public ComboCompleto() : base("Combo Completo", 500, 60) { }
        public override decimal CalcularPrecio() { return 500; }
        public override string GeneralLineraRecibo()
        {
            return string.Format("{0,-20} RD${1:N0}", "* COMBO *", 500);
        }
    }
}
