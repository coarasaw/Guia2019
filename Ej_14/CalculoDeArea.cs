using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double a)
        {
            return a * a;
        }

        public static double CalcularTriangulo(double a, double b)
        {
            return (a * b) / 2;
        }

        public static double CalcularCirculo(double a)
        {
            return Math.PI * a;
        }
    }
}
