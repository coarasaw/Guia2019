using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_54
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Title = "Ej_54";                                                                

                MiClase mc = new MiClase();
            }
            catch (Exception e)
            {
                // Busco el Path de una carpeta de sistema
                DateTime myDateTime = DateTime.Now;
                string year = myDateTime.Year.ToString();
                string mes = myDateTime.Month.ToString();
                string dia = myDateTime.Day.ToString();
                string hora = myDateTime.Hour.ToString();
                string minuto = myDateTime.Minute.ToString();
                string fecha = year + mes + dia + "-" + hora + minuto;

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = folder + Path.DirectorySeparatorChar + "Ej54-" + fecha + ".txt";
                ArchivoTexto.Guardar(filePath, e.ToString());
                
                Console.WriteLine("Path {0}", filePath);
                Console.ReadKey();

                Console.WriteLine($"Catch externo {e}");
            }
            Console.ReadKey();
        }
    }
}
