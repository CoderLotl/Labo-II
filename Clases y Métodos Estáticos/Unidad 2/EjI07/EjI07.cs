using System;
using Biblioteca;

namespace EjI07
{
    internal class EjI07
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
            El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
            Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
            Mostrar el resultado en la consola.*/

            double basex = 0;
            double height = 0;
            double hypotenuse = 0;
            int error = 0;

            Console.WriteLine("Pitágoras estaría orgulloso.\n\nPresione una tecla...");
            Console.WriteLine("\nA continuación ingrese la BASE y ALTURA de un triángulo.\nEl programa devolverá la" +
                "longitud de la hipotenusa.\n\n\n");
            Console.ReadKey();

            do
            {
                error = 0;
                Console.Write("Ingrese la BASE del triángulo: ");
                if ((basex = Validador.NumEntryDouble(0)) < 1)
                {
                    Validador.Error("Error. Numero fuera de rango.");
                    error = 1;
                }
            } while (error != 0);

            do
            {
                error = 0;
                Console.Write("Ingrese la ALTURA del triángulo: ");
                if ((height = Validador.NumEntryDouble(0)) < 1)
                {
                    Validador.Error("Error. Numero fuera de rango.");
                    error = 1;
                }
            } while (error != 0);

            hypotenuse = Math.Sqrt((Math.Pow(basex,2))+(Math.Pow(height,2)));
            Console.Write("\nEl largo de la HIPOTENUSA es: {0}", hypotenuse);
            Console.ReadKey();
        }
    }
}
