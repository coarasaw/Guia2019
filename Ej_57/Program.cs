using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_57";
            string archivo;
            Persona personaLeida;
            Persona persona = new Persona("Ortiz", "Mariana");
            archivo = Persona.Guardar(persona);  // Guardo la ruta y el nombre del archivo

            //Leo Archivo generado arriba
            Persona p2 = new Persona();
            personaLeida = Persona.Leer(p2, archivo);
            Console.WriteLine(personaLeida.ToString());
            Console.ReadKey();
        }
    }
}
