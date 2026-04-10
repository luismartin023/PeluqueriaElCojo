using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Atributos
{
  
        //Indicamos que se debe usar en propiedades
        [AttributeUsage(AttributeTargets.Property)]

        public abstract class ValidacionAttribute : Attribute
        {
            public string MensajeError {get; set;}

            //Metodo abstracto con bool

            public abstract bool EsValido(object valor);
        }
    
}
