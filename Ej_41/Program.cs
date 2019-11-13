using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_41";

            Centralita Telefonica = new Centralita("Telefonica");
            Local uno = new Local("Quilmes", 0.3f, "Quilmes", 2.65f);
            Provincial dos = new Provincial("Bs As", Franja.Franja_1, 0.21f, "Jujuy");
            Local tres = new Local("Quilmes", 0.45f, "Avellanda", 1.99f);
            try
            {
                Telefonica = Telefonica + uno;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine("Primer Error");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nombre Clase    ----> {0}", ex.NombreClase);
                Console.WriteLine("Nombre Metodo   ----> {0}", ex.NombreMetodo);
                Console.WriteLine("Inner Exception ----> {0}", ex.InnerException);
                Console.WriteLine("---------------");
            }

            try
            {
                Telefonica = Telefonica + uno;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine("Segundo Error");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nombre Clase    ----> {0}", ex.NombreClase);
                Console.WriteLine("Nombre Metodo   ----> {0}", ex.NombreMetodo);
                Console.WriteLine("Inner Exception ----> {0}", ex.InnerException);
                Console.WriteLine("---------------");
            }

            try
            {
                Telefonica = Telefonica + dos;
            }
            catch (CentralitaException ex)
            {
                Console.WriteLine("Tercer Error");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nombre Clase    ----> {0}", ex.NombreClase);
                Console.WriteLine("Nombre Metodo   ----> {0}", ex.NombreMetodo);
                Console.WriteLine("Inner Exception ----> {0}", ex.InnerException);
                Console.WriteLine("---------------");
            }


            Console.WriteLine(Telefonica.ToString());

            Console.ReadKey();
        }
    }
}
