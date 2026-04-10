using PeluqueriaElCojo.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PeluqueriaElCojo.Utilidades
{
    public static class Validador
    {
        public static List<string> Validar(object objeto)
        {
            List<string> errores = new List<string>();
            Type tipo = objeto.GetType();

            foreach (PropertyInfo prop in tipo.GetProperties())
            {
                // Obtenemos los atributos de validación de la propiedad
                var atributos = prop.GetCustomAttributes(typeof(ValidacionAttribute), true);
                foreach (ValidacionAttribute attr in atributos)
                {
                    object valor = prop.GetValue(objeto);
                    if (!attr.EsValido(valor))
                    {
                        errores.Add(string.Format("{0}: {1}", prop.Name, attr.MensajeError));
                    }
                }
            }
            return errores;
        }
    }
}
