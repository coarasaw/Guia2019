using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
               distintos de cero de forma aleatoria utilizando la clase Random.
                a. Mostrar el vector tal como fue ingresado
                b. Luego mostrar los positivos ordenados en forma decreciente.
                c. Por último, mostrar los negativos ordenados en forma creciente
             */
            Console.Title = "Ej_26";

            int[] vector = new int[20];
            int[] vectorPositivo = new int[20];
            int[] vectorNegatvo = new int[20];

            Random numero = new Random();
            int contPos = 0, contNeg = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = numero.Next(-100, 100);
                Console.WriteLine("Posición {0} Valor {1} ", i, vector[i].ToString());
                if (vector[i] > 0)
                {
                    vectorPositivo[contPos] = vector[i];
                    contPos++;
                }
                else
                {
                    if(vector[i] != 0)
                    {
                        vectorNegatvo[contNeg] = vector[i];
                        contNeg++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Positivos ------------");
            foreach (int item in vectorPositivo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Negativos -------------");
            foreach (int item in vectorNegatvo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Positivos Ordenados ------------");
            for (int k = 0; k < 19; k++)
            {
                for (int f = 0; f < 19-k; f++)
                {
                    if (vectorPositivo[f] < vectorPositivo[f + 1])
                    {
                        int aux;
                        aux = vectorPositivo[f];
                        vectorPositivo[f] = vectorPositivo[f + 1];
                        vectorPositivo[f + 1] = aux;
                    }
                }
            }
            foreach (int item in vectorPositivo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Negativos Ordenados -------------");
            Array.Sort(vectorNegatvo);
            foreach (int item in vectorNegatvo)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
