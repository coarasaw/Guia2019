using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Ej31;

namespace Ej_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_31";

            Cliente c1 = new Cliente(1, "Mariana");
            Cliente c2 = new Cliente(2, "Bety");

            PuestoAtencion p1 = new PuestoAtencion(Puesto.Caja1);
            PuestoAtencion p2 = new PuestoAtencion(Puesto.Caja2);

            Negocio n1 = new Negocio("Pipo");

            if (n1 + c1)
                Console.WriteLine("Agrego un cliente");
            else
                Console.WriteLine("No Agrego cleinte");

            if (n1 + c2)
                Console.WriteLine("Agrego un cliente");
            else
                Console.WriteLine("No Agrego cleinte");

            Console.WriteLine(n1.Mostrar());
            Console.ReadKey();
        }
    }
}
