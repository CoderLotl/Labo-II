using System;

namespace EjI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo)
            // que son divisores del número.
            // El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            // Escribir una aplicación que encuentre los 4 primeros números perfectos.

            int times = 0;
            int i;
            int j;

            Console.WriteLine("Un numero perfecto\n\n\nPress any key...");
            Console.ReadKey();

            Console.WriteLine("\nLos 4 primeros numeros perfectos son: ");

            for (i = 1; times < 5; i++)
            {
                int sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write(" {0} ", i);
                    times += 1;
                }
            }
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
