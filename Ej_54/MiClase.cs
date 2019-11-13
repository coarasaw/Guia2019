using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_54
{
    public class MiClase
    {
        // b. Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
        public static bool McStatic(int num)
        {
            Console.WriteLine("Metodo estatico que lanza excepcion \n");
            throw new DivideByZeroException();
        }

        /* c. Capturar la excepción del punto a en un constructor de instancia y relanzarla 
              hacia otro constructor de instancia. */
        public MiClase(int num)
        {
            try
            {
                MiClase.McStatic(1);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Catch DivideByZeroException \n\n{e}\n\n");
                throw e;
            }
            //catch (Exception e) { Console.WriteLine($"Catch Exception  GENERAL \n\n{e}\n\n"); }

            Console.WriteLine("Despues del Try catch \n");
        }

        /* d. En este segundo constructor, crear una excepción propia llamada UnaException (utilizar
              innerException para almacenar la excepción original) y volver a lanzarla.*/
        public MiClase() //: this(0)
        {
            try
            {
                new MiClase(9);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Catch Segundo constructor UnaException \n\n{e}\n\n");
                throw new UnaException("un mensaje", e);
            }
        }
        public bool McInstance(int num)
        {
            return false;
        }
    }
}
