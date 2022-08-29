using System;

namespace EjI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            // Validar que el dato ingresado por el usuario sea un número.
            // Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            // Si ingresa "salir", cerrar la consola.
            // Al finalizar, preguntar al usuario si desea volver a operar.
            // Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.

            string num1Str;
            string answ = "";
            int num1 = 0;
            int error = 0;
            int i;
            int j;

            Console.WriteLine("Numeros Primos\n\n\nPress any key...");
            Console.ReadKey();

            do
            {
                do
                {
                    Console.Write("\n\nIngrese un numero (negativos inclusive): ");
                    num1Str = Console.ReadLine();

                    if (num1Str == "salir")
                    {
                        Environment.Exit(0);
                    }
                    else if (int.TryParse(num1Str, out _) == false)
                    {
                        Console.WriteLine("\nError.\nLo ingresado no es un numero.");
                    }

                } while (int.TryParse(num1Str, out _) == false);

                num1 = int.Parse(num1Str);

                Console.WriteLine("\nNumeros primos hasta {0}:", num1);

                if (num1 > 0)
                {
                    for (i = 2; i <= num1; i++)
                    {
                        int c = 0;
                        for (j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                c++;
                            }
                        }
                        if (c == 2)
                        {
                            Console.Write(" {0} ", i);
                        }
                    }
                }
                else if (num1 < 0)
                {
                    for (i = -2; i >= num1; i--)
                    {
                        int c = 0;
                        for (j = -1; j >= i; j--)
                        {
                            if (i % j == 0)
                            {
                                c++;
                            }
                        }
                        if (c == 2)
                        {
                            Console.Write(" {0} ", i);
                        }
                    }
                }
                Console.ReadKey();
                do
                {
                    error = 0;
                    Console.Write("\n\nDesea repetir la funcion? [ SI | NO ] ");
                    answ = Console.ReadLine();

                    if (answ != "si" && answ != "no")
                    {
                        Console.WriteLine("\n\nError. - Ingrese sólo 'si' o 'no'.");
                        error = 1;
                    }

                } while (error != 0);
                if (answ == "si")
                {
                    Console.Clear();
                }
            } while (answ != "no");
            Console.WriteLine("\nCerrando programa...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
