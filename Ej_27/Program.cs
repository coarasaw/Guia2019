using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el ejercicio anterior pero 
            //esta vez con las siguientes colecciones: Pilas, Colas y Listas.

            Console.Title = "Ej_27";
            List<int> lista = new List<int>();
            // Positivos Colas & Pilas
            Queue<int> colaPos = new Queue<int>();
            Stack<int> pilaPos = new Stack<int>();
            // Negativos Colas & Pilas
            Queue<int> colaNeg = new Queue<int>();
            Stack<int> pilaNeg = new Stack<int>();

            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(r.Next(-100, 100));
            }

            Console.WriteLine("Muestro Lista Original");
            foreach (int itemLista in lista)
            {
                Console.WriteLine(itemLista);
            }

            Console.WriteLine("Muestro Lista Ordenada");
            lista.Sort();
            foreach (int itemLista in lista)
            {
                Console.WriteLine(itemLista);
            }

            Console.WriteLine("Muestro Lista Positivos");
            foreach (int itemLista in lista)
            {
                if (itemLista > 0)
                {
                    Console.WriteLine(itemLista);
                    colaPos.Enqueue(itemLista);
                }
                else
                {
                    if (itemLista != 0)
                    {
                        pilaNeg.Push(itemLista);
                    }
                }
            }

            Console.WriteLine("Muestro Lista de Negativos");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    pilaPos.Push(lista[i]);
                }
                else if (lista[i] != 0)
                {
                    Console.WriteLine(lista[i]);
                    colaNeg.Enqueue(lista[i]);
                }
            }
            Console.WriteLine("Muestro Cola Positivos");
            foreach (int i in colaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muestro Pila Positivos");
            foreach (int i in pilaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muestro Cola Negativos");
            foreach (int i in colaNeg)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muestro Pila Negativos");
            foreach (int i in pilaNeg)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
