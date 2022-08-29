using System;

namespace EjI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en
            //dos grupos de números, cuyas sumas son iguales.
            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos:
            //(1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15.
            //El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los grupos:
            //(1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

            string numStr;
            int num = 0;
            int error = 0;
            int centro = 0;
            int sumasPrevias = 0;
            int numsPrevios = 0;
            int sumasPosteriores = 0;
            int numsPosteriores = 0;

            Console.WriteLine("Tirame un centro.\n\n\nPress any key...");
            Console.ReadKey();

            do
            {
                error = 0;
                Console.Write("\n\nIngrese un numero: ");
                numStr = Console.ReadLine();

                if (int.TryParse(numStr, out _) == false)
                {
                    Console.WriteLine("\nError.\nLo ingresado no es un numero.");
                    error = 1;
                }

            } while (error!=0);

            num = int.Parse(numStr);
            
            for (centro= 1; centro < num; centro++)
            {
                sumasPrevias = 0;                
                for (numsPrevios =1; numsPrevios < centro; numsPrevios++)
                {
                    sumasPrevias += numsPrevios;
                }

                sumasPosteriores = 0;                
                for (numsPosteriores = centro + 1; numsPosteriores <= sumasPrevias; numsPosteriores++)
                {                    
                    if (sumasPosteriores >= sumasPrevias)
                    {
                        break;
                    }
                    sumasPosteriores += numsPosteriores;
                }
                
                if (sumasPrevias == sumasPosteriores)
                {
                    Console.WriteLine($"Centro: {centro}");
                }
            }
        }
    }
}
