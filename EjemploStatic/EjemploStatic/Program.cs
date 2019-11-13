using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploStatic
{
    public class Automobile
    {
        public static int NumberOfWheels = 4;
        public int variable;

        public static int SizeOfGasTank
        {
            get
            {
                
                return 15;
            }
        }
        public static void Drive()
        {
            NumberOfWheels = 5;
        }

        public void Escribir()
        {
            
            Automobile.NumberOfWheels = 0;
        }
        //public static event EventType RunOutOfGas;

        // Other non-static fields and properties...
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobile a = new Automobile();

            Automobile.Drive();
        }
    }
}
