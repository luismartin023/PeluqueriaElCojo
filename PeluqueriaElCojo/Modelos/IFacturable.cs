using System;

namespace PeluqueriaElCojo.Modelos
{
    public interface IFacturable
    {
        decimal CalcularPrecio();
        string GeneralLineraRecibo();
    }

}
