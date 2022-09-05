using System;
using Biblioteca;

namespace EjI02
{
    internal class EjI02
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
            Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

            int num1 = 0;
            int num2 = 0;
            bool answ = false;

            Console.WriteLine("¿Desea continuar?.\n\nPresione una tecla...");
            Console.ReadKey();
            Console.WriteLine("A continuación se solicitará el ingreso de 2 números.\nPosteriormente se sumarán ambos hasta que el usuario decida.\n\nPresione una tecla...\n\n\n");
            Console.ReadKey();

            do
            {
                if (answ == true)
                {
                    Console.Clear();
                }
                num1 = Validador.NumEntry(1);
                num2 = Validador.NumEntry(2);
                Console.WriteLine("{0} + {1} = " + (num1 + num2), num1, num2);

                answ = Validador.ValidarRespuesta();

            } while (answ != false);
        }
    }
}