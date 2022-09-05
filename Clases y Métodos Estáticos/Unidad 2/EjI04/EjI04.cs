using System;
using Biblioteca;

namespace EjI04
{
    internal class EjI04
    {
        static void Main(string[] args)
        {
            /* Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
            El método devolverá el resultado de la operación.
            Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
            --- Este método devolverá true si el operando es distinto de cero.
            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
            El usuario decidirá cuándo finalizar el programa.*/

            bool answ = false;
            char str;
            int num1 = 0;
            int num2 = 0;
            string total;

            Console.WriteLine("Calculadora.\n\nPresione una tecla...");
            Console.ReadKey();
            Console.WriteLine("A continuación se pedirán 2 números y un símbolo de ecuación.\nLa función devolverá el resultado.");


            do
            {
                num1 = Validador.NumEntry(1);
                num2 = Validador.NumEntry(2);

                Console.Write("Ingrese el operador a usar: ");
                str = Console.ReadKey().KeyChar;


                total = Calculadora.Calcular(num1, num2, str);

                if (int.TryParse(total, out _) != false)
                {
                    Console.WriteLine("\n\nTotal: {0}", total);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(total);
                    Console.ReadKey();
                }

                answ = Validador.ValidarRespuesta();
            } while (answ != false);
        }
    }
}