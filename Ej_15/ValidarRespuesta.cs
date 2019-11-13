using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    public static class ValidarRespuesta
    {
        static public bool Validar(string caracter)
        {
            bool verdadero = true;

            if (caracter == "S" || caracter == "s")
            {
                return verdadero;
            }
            else
            {
                return verdadero = false;
            }

        }
    }
}
