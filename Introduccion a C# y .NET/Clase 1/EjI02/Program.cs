using System;

namespace EjI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            // Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            string numStr = "";
            int error = 0;
            double num = 0;
            double square = 0;
            double trice = 0;

            Console.WriteLine("Error al cubo\n\n\nPress any key...");
            Console.ReadKey();

            do
            {
                do
                {
                    error = 0;
                    Console.WriteLine("\nIngrese un numero MAYOR a 0:");
                    numStr = Console.ReadLine();
                    if (double.TryParse(numStr, out _) == false)
                    {
                        Console.WriteLine("\nERROR. ¡Reingresar número!");
                        error = 1;
                    }
                } while (error != 0);
                num = double.Parse(numStr);

                if (num <= 0)
                {
                    Console.WriteLine("\nError.\nEl numero debe ser mayor a 0.");
                    Console.ReadKey();
                }
            } while (num <= 0);

            square = Math.Pow(num, 2);
            trice = Math.Pow(num, 3);

            Console.WriteLine("\nEl numero es: {0}\nEl cubo de {0} es: {1}\n{0} elevado a la 3 es: {2}", num, square, trice);
            Console.ReadKey();
        }
    }
}
