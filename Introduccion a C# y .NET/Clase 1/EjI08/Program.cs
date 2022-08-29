using System;

namespace EjI08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribir un programa que imprima por consola un triángulo como el siguiente:

            // *
            // ***
            // *****
            // *******
            // *********

            int error = 0;
            string auxStr = "";
            string symbol = "*";
            int num = 0;
            int i;
            int j;

            Console.WriteLine("Dibujando un triángulo rectángulo.\n\n\nPress any key...");
            Console.ReadKey();
            do
            {
                error = 0;
                Console.Write("\n\n\nIngrese la altura del triángulo: ");
                auxStr = Console.ReadLine();
                if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) <= 0)
                {
                    Console.WriteLine("\nError. - Lo ingresado no es un número válido. Debe ser mayor a 0.");
                    error = 1;
                }
            } while (error != 0);
            num = int.Parse(auxStr);
            Console.Write("\n\n");

            for (i = 0; i < num; i++)
            {
                for (j = 0; j < (i + 1); j++)
                {
                    Console.Write(" {0} ", symbol);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }
    }
}
