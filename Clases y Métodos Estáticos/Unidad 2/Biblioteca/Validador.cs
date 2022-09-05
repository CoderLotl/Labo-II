using System;

namespace Biblioteca
{
    public class Validador
    {
        public static int NumEntry(int i)
        {
            string numStr;
            int num = 0;
            int error = 0;

            do
            {
                error = 0;
                Console.Write("\nIngrese el número");
                if (i > 0)
                {
                    Console.Write(" #{0}", i);
                }
                Console.Write(": ");
                numStr = Console.ReadLine();
                if (int.TryParse(numStr, out num) == false)
                {
                    Console.WriteLine("ERROR. - Lo ingresado no es un número.");
                    error = 1;
                }
            } while (error != 0);
            return num;
        }

        ///-----------------------------------------

        public static double NumEntryDouble(int i)
        {
            string numStr;
            double num = 0;
            int error = 0;

            do
            {
                error = 0;
                Console.Write("\nIngrese el número");
                if (i > 0)
                {
                    Console.Write(" #{0}", i);
                }
                Console.Write(": ");
                numStr = Console.ReadLine();
                if (double.TryParse(numStr, out num) == false)
                {
                    Console.WriteLine("ERROR. - Lo ingresado no es un número.");
                    error = 1;
                }
            } while (error != 0);
            return num;
        }

        ///-----------------------------------------

        public static bool ValidarRespuesta()
        {
            string answ;
            Console.Write("¿Desea continuar? (S/N) ");
            answ = Console.ReadLine();

            return (answ == "S") ? true : false;
        }

        ///-----------------------------------------

        public static bool Validar(int valor, int min, int max)
        {
            return (valor > max || valor < min) ? false : true;
        }

        ///-----------------------------------------

        public static void Error(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        ///-----------------------------------------

    }
}
