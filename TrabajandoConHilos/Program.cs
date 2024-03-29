﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrabajandoConHilos
{
    class Program
    {
        public static void LlamarHoloHijo()
        {
            //Console.WriteLine("El Hilo Hijo se está ejecutando");

            //Segundo Ejemplo sobre el mismo progranma
            /*
            Console.WriteLine("Comienza la ejecución del Hilo Hjo");
            int parar = 5000;
            Console.WriteLine("El Hilo Hijo se parará durante {0} segundos", parar / 1000);
            Thread.Sleep(parar);
            Console.WriteLine("El Hilo Hijo continua su ejecución");
            */
            try
            {
                Console.WriteLine("Comienza la ejecución del Hilo Hijo");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i);
                }
                Console.WriteLine("El Hilo Hijo se ha completado");
            }
            catch (ThreadAbortException e)
            {

                Console.WriteLine("Se ha producido la Excepción: ", e);
            }
            finally
            {
                Console.WriteLine("No se ha producido ningún error en la ejecución del Hilo Hijo");
            }

        }
        static void Main(string[] args)
        {
            ThreadStart refHijo = new ThreadStart(LlamarHoloHijo);
            Console.WriteLine("El Hilo Principal --> Está crando el hilo Hijo");

            Thread HiloHijo = new Thread(refHijo);
            HiloHijo.Start();

            Thread.Sleep(2000);
            Console.WriteLine("El Hilo Principal va a destruir el Hilo Hijo");
            HiloHijo.Abort();

            Console.ReadKey();
        }
    }
}
