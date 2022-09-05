using System;
using System.Text;
using Biblioteca;

namespace EjI05
{
    internal class EjI05
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación de consola que permita al usuario ingresar un número entero.
            Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación
            de ese número en formato string.
            Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
            Mostrar en la consola el resultado.
            Por ejemplo, si se ingresa el número 2 la salida deberá ser:*/

            int num;
            int i;

            Console.WriteLine("Aprendete las tablas.\n\nPresione una tecla...");
            Console.ReadKey();
            Console.WriteLine("A continuación se pedirán 1 número.\nSe devolverá su tabla de multiplicación.");

            num = Validador.NumEntry(0);

            Console.WriteLine("\n\nTabla de multiplicar del número {0}:\n",num);

            for (i = 0; i < 11; i++)
            {
                StringBuilder text = new StringBuilder();
                text.AppendFormat("{0} x {1} = {2}", num, i,(num*i));
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
