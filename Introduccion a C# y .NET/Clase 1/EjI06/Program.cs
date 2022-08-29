using System;

namespace EjI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos,
            //salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

            string numStr;
            int num = -1;
            int num2 = -1;
            int aux;
            int i;
            int rows = 0;
            int error = 0;

            Console.WriteLine("Años bisiestos\n\n\nPress any key...");
            Console.ReadKey();
            Console.WriteLine("\nA continuacion se mostrarán todos los años bisiestos entre 2 años ingresados.");
            do
            {
                error = 0;
                if (num == -1)
                {
                    Console.Write("\nIngrese el primer año: ");
                }
                else
                {
                    Console.Write("\nIngrese el segundo año: ");
                }
                numStr = Console.ReadLine();
                if (int.TryParse(numStr, out _) == false || int.Parse(numStr) < 0)
                {
                    Console.WriteLine("\nError.\nLo ingresado no es un numero, o no es un número válido.");
                    error = 1;
                }
                else
                {
                    if (num == -1)
                    {
                        num = int.Parse(numStr);
                        rows++;
                    }
                    else
                    {
                        num2 = int.Parse(numStr);
                        rows++;
                    }
                }
            } while ((rows < 2) || (error != 0));

            if (num > num2)
            {
                aux = num2;
                num2 = num;
                num = aux;
            }
            Console.Clear();
            Console.WriteLine("\n\nLos años bisiestos entre el año {0} y el año {1} son:", num, num2);

            for (i = num; i < num2; i++)
            {
                if (i % 100 == 0 && i % 400 == 0)
                {
                    Console.Write(" {0} ", i);
                }
                else if (i % 4 == 0 && i % 100 != 0)
                {
                    Console.Write(" {0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
