using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Atributos
{
    public class RangoAttribute : ValidacionAttribute
    {
        public double Minimo { get; }
        public double Maximo { get; }

        public RangoAttribute(double min, double max)
        {
            Minimo = min;
            Maximo = max;
            MensajeError = string.Format("El valor debe estar entre {0} y {1}", min, max);
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return true;
            double num = Convert.ToDouble(valor);
            return num >= Minimo && num <= Maximo;
        }
    }
}
