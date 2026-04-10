using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Atributos
{
    public class RequeridoAttribute : ValidacionAttribute
    {
        public RequeridoAttribute()
        {
            MensajeError = "Este Campo es requerido";
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return false;
            if (valor is string s) return !string.IsNullOrWhiteSpace(s);
            return true;
        }

    }
}
