using System;
using Biblioteca;

namespace EjI01
{
    internal class EjI01
    {
        static void Main(string[] args)
        {
            /*Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
            bool Validar(int valor, int min, int max)
            valor: dato a validar.
            min: mínimo valor incluido.
            max: máximo valor incluido.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
            Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/

            int num = 0;
            int min = 0;
            int max = 0;
            float average = 0;
            int flag = 0;
            int i;
            int error = 0;

            Console.WriteLine("Validador de rangos.\n\nPresione una tecla...");
            Console.ReadKey();
            Console.WriteLine("A continuación se solicitará el ingreso de 10 números entre -100 y 100.\nPosteriormente se determinará el máximo y el mínimo.\n\nPresione una tecla...\n\n\n");
            Console.ReadKey();

            for (i = 0; i < 10; i++)
            {
                do
                {
                    error = 0;
                    num = Validador.NumEntry(i + 1);
                    if (Validador.Validar(num, -100, 100) == false)
                    {
                        Console.WriteLine("ERROR. - El número ingresado está por fuera del rango.");
                        error = 1;
                    }
                } while (error != 0);

                if (flag == 0)
                {
                    min = num;
                    max = num;
                    flag = 1;
                }
                else
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
                average += num;
            }

            average = average / 10;

            Console.WriteLine("Número mínimo: {0} || Número máximo: {1} || Promedio: {2}", min, max, average);
            Console.ReadKey();
        }
    }
}