using System;

namespace PeluqueriaElCojo.Modelos
{
    public class Cliente
    {
        private string _nombre;
        private string _telefono;
        private int _visitas;
        private static int _contadorId = 0;

        public int Id { get; private set; }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                string limpio = value.Replace(" ", "").Replace("-", "");
                if (limpio.Length != 10)
                    throw new ArgumentException("Telefono: 10 digitos");
                _telefono = limpio;
            }
        }

        public TipoCliente Tipo { get; set; }
        public int Visitas { get { return _visitas; } }
        public DateTime FechaRegistro { get; private set; }

        public Cliente(string nombre, string telefono)
        {
            Id = ++_contadorId;
            Nombre = nombre;
            Telefono = telefono;
            Tipo = TipoCliente.Nuevo;
            _visitas = 0;
            FechaRegistro = DateTime.Now;
        }

        public void RegistrarVisita()
        { 
            _visitas++;
            if (_visitas >= 10) Tipo = TipoCliente.VIP;
            else if (_visitas >= 3) Tipo = TipoCliente.Regular;
        }

        public decimal ObtenerDescuento()
        {
            switch (Tipo)
            {
                case TipoCliente.Regular: return 0.15m;
                case TipoCliente.VIP: return 0.05m; 
                default: return 0m; 
            }
        }

        public string TelefonoFormateado()
        {
            return _telefono.Substring(0, 3) + "-" +
                   _telefono.Substring(3, 3) + "-" +
                   _telefono.Substring(6);
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} ({2}) - {3}", Id, Nombre, Tipo, TelefonoFormateado());
        }

    }
    
}
