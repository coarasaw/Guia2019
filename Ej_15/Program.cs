using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";

            /*
            Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * ó /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
            operación matemática. El método devolverá el resultado de la operación.
            b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
            TRUE si el número es distinto de CERO.
             */

            int numero1, numero2, resultado;
            
            //string operacion, caracter;

            char operacion;
            string caracter;
            bool success;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            do
            {
                Console.Write("Ingrese un número para realizar una operación[1]: ");

                // Cambio el ingreso del dato con Parse por TryParse, para ver la diferencia. 
                //numero1 = int.Parse(Console.ReadLine());
                
                success = Int32.TryParse(Console.ReadLine(), out numero1);
                while (!success)
                {
                    Console.WriteLine("Error al ingresar el dato 1");
                    Console.Write("Reingrese un número para realizar una operación[1]: ");
                    success = Int32.TryParse(Console.ReadLine(), out numero1);
                }
                //success = null;

                Console.Write("Ingrese un número para realizar una operación[2]: ");                
                success = Int32.TryParse(Console.ReadLine(), out numero2);
                while (!success) 
                {
                    Console.WriteLine("Error al ingresar el dato 2");
                    Console.Write("Reingrese un número para realizar una operación[2]: ");
                    success = Int32.TryParse(Console.ReadLine(), out numero2);
                } 

                Console.Write("Ingrese la operación a efectuar[+-*/]:            ");
                //operacion = Console.ReadLine();

                success = char.TryParse(Console.ReadLine(), out operacion);
                while (!success && (operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/'))
                {
                    Console.WriteLine("Error al ingresar la operación");
                    Console.Write("Reingrese la operación a efectuar[+-*/]: ");
                    success = char.TryParse(Console.ReadLine(), out operacion);
                } 

                resultado = Calculadora.Calcular(numero1, numero2, operacion);
                Calculadora.Mostrar(resultado);
                Console.Write("\nDesea [S] Salir sino pulse otra tecla  :      ");
                caracter = Console.ReadLine();
                Console.Clear();
            }
            while (!ValidarRespuesta.Validar(caracter));
            Console.ResetColor();
            
        }
    }
}
