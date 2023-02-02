using System;

namespace EjI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int times = 0; //cantidad de veces que voy iterando
            string numberString = ""; //Str de toma de datos
            int number = 0; //int, dato numerico que voy a usar
            int flag = 0;
            int max = 0; //numero maximo
            int min = 0; //numero minimo
            float avg = 0; //numero promedio

            //-----------------------------------------------

            Console.WriteLine("Maximo, Minimo, y Promedio.\n\n\nPress any key...");
            Console.ReadKey();

            for (times = 0; times < 5; times++)
            {
                do
                {
                    Console.WriteLine("\n---------------------------\nIngrese un numero #{0}: ", times + 1);
                    numberString = Console.ReadLine();

                    if (numberString == "")
                    {
                        Console.WriteLine("\nError.\nDebe ingresar un numero.");
                    }
                } while (numberString == "");
                number = int.Parse(numberString);
                Console.WriteLine("\nNumero ingresado {0}", number);

                if (flag == 0)
                {
                    max = number;
                    min = number;
                    flag = 1;
                }
                else
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
                avg += number;
            }
            avg = avg / 5;
            Console.WriteLine("\n------------------------------\nNumero maximo: {0}\nNumero Minimo: {1}\nNumero promedio: {2}", max, min, avg);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }    
    }
}
