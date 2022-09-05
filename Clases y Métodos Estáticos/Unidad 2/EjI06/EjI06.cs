using System;
using Biblioteca;

namespace EjI06
{
    internal class EjI06
    {
        static void Main(string[] args)
        {
            int opt=0;
            int error = 0;

            Console.WriteLine("Calculadora de áreas.\n\nPresione una tecla...");
            Console.ReadKey();

            do
            {
                Console.Write("\n\n1) Area de un cuadrado.\n2) Area de un triangulo.\n3) Area de un circulo.\n4) [ SALIR ]");
                do
                {
                    error = 0;
                    opt = Validador.NumEntry(0);
                    if (opt>4 || opt<1){
                        Error("Error. Numero fuera de rango.");
                        error = 1;                        
                    }
                } while (error != 0);

                switch (opt)
                {
                    case 1:
                        AreaCuadrado();
                        break;
                    case 2:
                        AreaTriangulo();
                        break;
                    case 3:
                        AreaCirculo();
                        break;
                }
                Console.Clear();
            } while (opt != 4);
        }

        ///-----------------------------------------

        static void AreaCuadrado()
        {
            double LadoCuadrado = 0;
            int error = 0;
            double area = 0;
            Console.Write("\n//////\n//////\n//////\n\n\nIngrese el largo en unidades de uno de los lados del cuadrado: ");
            do
            {
                error = 0;
                if((LadoCuadrado = Validador.NumEntryDouble(0)) < 1)
                {
                    Error("Error. Numero fuera de rango.");
                    error = 1;                    
                }                
            } while (error != 0);
            area = CalculadoraDeArea.CalcularAreaCuadrado(LadoCuadrado);
            Answer("Cuadrado", area);
        }

        ///-----------------------------------------

        static void Error (string message){
            Console.WriteLine(message);            
            Console.ReadKey();
        }

        ///-----------------------------------------

        static void Answer(string message, double number)
        {
            Console.WriteLine("El area del {0} es: {1}", message,number);
            Console.ReadKey();
        }


        ///-----------------------------------------

        static void AreaTriangulo()
        {
            double basex = 0;
            double height = 0;
            int error = 0;
            double area = 0;

            Console.Write("\n//////\n//////\n//////\n\n\nIngrese la BASE y ALTO en unidades de uno de los lados del triangulo:");
            do
            {
                error = 0;
                Console.Write("\n\nBase: ");
                if ((basex = Validador.NumEntryDouble(0)) < 1)
                {
                    Error("Error. Numero fuera de rango.");
                    error = 1;
                }
            } while (error != 0);

            do
            {
                error = 0;
                Console.Write("\n\nAltura: ");
                if ((height = Validador.NumEntryDouble(0)) < 1)
                {
                    Error("Error. Numero fuera de rango.");
                    error = 1;
                }
            } while (error != 0);

            area = CalculadoraDeArea.CalcularAreaTriangulo(basex, height);
            Answer("Triangulo", area);
        }

        ///-----------------------------------------

        static void AreaCirculo()
        {
            double radio = 0;
            int error = 0;
            double area = 0;
            Console.Write("\n//////\n//////\n//////\n\n\nIngrese el largo en unidades del RADIO del circulo:");
            do
            {
                error = 0;
                if ((radio = Validador.NumEntryDouble(0)) < 1)
                {
                    Error("Error. Numero fuera de rango.");
                    error = 1;
                }
            } while (error != 0);
            area = CalculadoraDeArea.CalcularAreaCirculo(radio);
            Answer("Circulo", area);
        }
    }
}
