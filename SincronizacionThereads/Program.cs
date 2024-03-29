﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SincronizacionThereads
{
    class Imprimir
    {
        public void ImprimirNumeros()
        {
            // Este ejemplo se comenta para hacer otro con Monitor
            //lock(this) //Hace que no se ejecute otro hilo hasta que no se termine de ejecutar uno
            //{ 
            Monitor.Enter(this);
            try
            { 
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
                //}
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Monitor.Exit(this);
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Se va realizar MultiTheading *****");

            Imprimir impr = new SincronizacionThereads.Imprimir();
            Thread[] hilo = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                hilo[i] = new Thread(new ThreadStart(impr.ImprimirNumeros));
                hilo[i].Name = "Hilo Hijo" + i;
            }
            foreach (Thread h in hilo)
            {
                h.Start();
            }

            Console.ReadKey();
        }
    }
}
