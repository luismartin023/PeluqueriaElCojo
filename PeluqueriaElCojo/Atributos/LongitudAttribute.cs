using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Atributos
{
    public class LongitudAttribute : ValidacionAttribute
    {
        public int Min { get; }
        public int Max { get; }


        public LongitudAttribute (int min, int max)
        {
            Min = min;
            Max = max;
            MensajeError = string.Format("Debe tener entre {0} y {1} caracteres", min, max);
        }

        public override bool EsValido(object valor)
        {
            if (valor == null) return Min == 0;
            string s = valor.ToString();
            return s.Length >= Min && s.Length <= Max;
        }

    }
}
