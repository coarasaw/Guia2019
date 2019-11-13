using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_38";

            Sobreescrito sobrecarga = new Sobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.Write("Comparación Sobrecargas con Sobreescrito: ");
            Console.WriteLine(sobrecarga.Equals(new Sobreescrito()));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}
