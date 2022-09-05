using System;
using Biblioteca;

namespace EjI03
{
    internal class EjI03
    {
        static void Main(string[] args)
        {
            /*Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
            El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.
                public string ConvertirDecimalABinario(int numeroEntero) {}
            El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
                public int ConvertirBinarioADecimal(int numeroEntero) {}*/

            string numStr;
            int num;
            int opt;

            Console.WriteLine("Conversor binario.\n\nPresione una tecla...");
            Console.ReadKey();

            Console.WriteLine("Escoja una opcion:\n\n1) Numero decimal a binario.\n2) Numero binario a decimal.\n3) [ SALIR ]\n");

            opt = Validador.NumEntry(0);

            switch (opt)
            {
                case 1:
                    num = Validador.NumEntry(0);
                    numStr = Conversor.ConvertirDecimalABinario(num);
                    Console.WriteLine("El numero en binario es: " + numStr);
                    Console.ReadKey();
                    break;
                case 2:
                    num = Validador.NumEntry(0);
                    num = Conversor.ConvertirBinarioADecimal(num);
                    Console.WriteLine("El numero en decimal es: " + num);
                    Console.ReadKey();
                    break;
                case 3:
                    break;
            }
        }
    }
}