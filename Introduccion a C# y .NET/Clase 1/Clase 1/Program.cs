using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Clase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string optStr;
            int opt;

            do
            {
                Console.Clear();
                Console.Write("Ingrese el número del ejercicio:\n\n" +
                    "\n1) Máximo, Mínimo, y Promedio.\n" +
                    "\n2) Error al cubo.\n" +
                    "\n3) Los primos.\n" +
                    "\n4) Un número perfecto.\n" +
                    "\n5) Tirame un centro.\n" +
                    "\n6) Años bisiestos.\n" +
                    "\n7) Recibo de sueldo.\n" +
                    "\n8) Dibujando un triángulo rectángulo.\n" +
                    "\n9) Dibujando un triángulo equilátero.\n" +
                    "\n\n10) [ SALIR ]\n\n");

                optStr = Console.ReadLine();
                opt = int.Parse(optStr);
                switch (opt)
                {
                    case 1:
                        Console.Clear();
                        ej1();
                        break;
                    case 2:
                        Console.Clear();
                        ej2();
                        break;
                    case 3:
                        Console.Clear();
                        ej3();
                        break;
                    case 4:
                        Console.Clear();
                        ej4();
                        break;
                    case 5:
                        Console.Clear();
                        ej5();
                        break;
                    case 6:
                        Console.Clear();
                        ej6();
                        break;
                    case 7:
                        Console.Clear();
                        ej7();
                        break;
                    case 8:
                        Console.Clear();
                        ej8();
                        break;
                    case 9:
                        Console.Clear();
                        ej9();
                        break;
                }
            } while (opt != 10);
            Environment.Exit(0);
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej1()
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int times = 0;
            string numberString="";
            int number = 0;
            int flag = 0;
            int max = 0;
            int min = 0;
            float avg = 0;

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
            Console.WriteLine("\n------------------------------\nNumero maximo: {0}\nNumero Minimo: {1}\nNumero promedio: {2}", min, max, avg);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej2()
        {
            // Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            // Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            string numStr ="";
            int error = 0;
            double num = 0;
            double square = 0;
            double trice = 0;

            Console.WriteLine("Error al cubo\n\n\nPress any key...");
            Console.ReadKey();

            do
            {
                do {
                    error = 0;
                    Console.WriteLine("\nIngrese un numero MAYOR a 0:");
                    numStr = Console.ReadLine();
                    if (double.TryParse(numStr, out _) == false)
                    {
                        Console.WriteLine("\nERROR. ¡Reingresar número!");
                        error = 1;
                    }
                }while(error!=0);
                num = double.Parse(numStr);

                if (num <= 0)
                {
                    Console.WriteLine("\nError.\nEl numero debe ser mayor a 0.");
                    Console.ReadKey();
                }
            } while (num <= 0);

            square = Math.Pow(num,2);
            trice = Math.Pow(num,3);

            Console.WriteLine("\nEl numero es: {0}\nEl cubo de {0} es: {1}\n{0} elevado a la 3 es: {2}",num,square,trice);
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej3()
        {
            // Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            // Validar que el dato ingresado por el usuario sea un número.
            // Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            // Si ingresa "salir", cerrar la consola.
            // Al finalizar, preguntar al usuario si desea volver a operar.
            // Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.

            string num1Str;
            string answ="";
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
                    
                    if(answ!="si" && answ != "no")
                    {
                        Console.WriteLine("\n\nError. - Ingrese sólo 'si' o 'no'.");
                        error = 1;
                    }

                } while (error != 0);
                if (answ == "si")
                {
                    Console.Clear();
                }
            } while(answ!="no");
            Console.WriteLine("\nCerrando programa...");            
            Console.ReadKey();
            Environment.Exit(0);
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej4()
        {
            // Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo)
            // que son divisores del número.
            // El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            // Escribir una aplicación que encuentre los 4 primeros números perfectos.

            int times = 0;
            int i;
            int j;

            Console.WriteLine("Un numero perfecto\n\n\nPress any key...");
            Console.ReadKey();

            Console.WriteLine("\nLos 4 primeros numeros perfectos son: ");

            for (i = 1; times < 5; i++)
            {
                int sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write(" {0} ", i);
                    times += 1;
                }
            }
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej5()
        {
            // Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
            // El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
            // cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos:
            // (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
            // Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.


            Console.WriteLine("ODIO MATEMATICAS Y NO ENTIENDOOOOOOOOOAAAAAAAAAAHHHHHHH!!!");
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej6()
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
                if (int.TryParse(numStr, out _) == false || int.Parse(numStr)<0)
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
            } while ((rows < 2) || (error!=0));

            if (num > num2)
            {
                aux = num2;
                num2 = num;
                num = aux;
            }
            Console.Clear();
            Console.WriteLine("\n\nLos años bisiestos entre el año {0} y el año {1} son:",num,num2);

            for (i = num; i < num2; i++)
            {   
                if(i%100==0 && i % 400 == 0)
                {
                    Console.Write(" {0} ", i);
                }
                else if (i % 4 == 0 && i%100!=0)
                {
                    Console.Write(" {0} ", i);
                }
            }
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej7()
        {
            // Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y la
            // cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
            // Se pide calcular el importe a cobrar teniendo en cuenta que el total
            // (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle
            // la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.
            // Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y
            // el total a cobrar neto de todos los empleados ingresados.

            string auxStr;
            int trabajadores=-1;
            int i;
            int error = 0;
            string data="";
            string nombre="";
            int valorHora=0;
            int cantidadHoras=0;
            int antiguedad=0;
            int descuento = 13;
            float totalBruto = 0;
            float totalNeto = 0;

            Console.WriteLine("Recibo de sueldo.\n\n\nPress any key...");
            Console.ReadKey();
            Console.WriteLine("\nA continuacion se pedirán los datos de N cantidad de trabajadores.\nLuego se mostrarán sus recibos de sueldo" +
                "por pantalla.");

            do
            {
                error = 0;
                Console.Write("\n*. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ." +
                                  "\n\n\nIngrese la cantidad de trabajadores cuyos datos se pedirán: ");
                auxStr = Console.ReadLine();
                if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) < 0)
                {
                    Console.WriteLine("\nError. - Lo ingresado no es un número válido.");
                    error = 1;
                }
                else
                {
                    trabajadores = int.Parse(auxStr);
                }
            } while (error!=0);

            for (i = 0; i < trabajadores; i++)
            {                
                Console.Write("\nIngrese el NOMBRE del trabajador #{0}: ", i+1);
                auxStr = Console.ReadLine();
                data = data + auxStr + ",";                

                do
                {
                    error = 0;
                    Console.Write("\nIngrese el VALOR HORA del trabajador #{0}: ", i+1);
                    auxStr = Console.ReadLine();
                    if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) < 0)
                    {
                        Console.WriteLine("\nError. - Lo ingresado no es un número válido.");
                        error = 1;
                    }
                } while (error != 0);
                data = data + auxStr + ",";

                do
                {
                    error = 0;
                    Console.Write("\nIngrese la ANTIGÜEDAD del trabajador #{0}: ", i+1);
                    auxStr = Console.ReadLine();
                    if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) <= 0)
                    {
                        Console.WriteLine("\nError. - Lo ingresado no es un número válido. Debe ser mayor a 0.");
                        error = 1;
                    }
                } while (error != 0);
                data = data + auxStr + ",";

                do
                {
                    error = 0;
                    Console.Write("\nIngrese las HORAS TRABAJADAS DEL MES del trabajador #{0}: ", i + 1);
                    auxStr = Console.ReadLine();
                    if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) <= 0)
                    {
                        Console.WriteLine("\nError. - Lo ingresado no es un número válido. Debe ser mayor a 0.");
                        error = 1;
                    }
                } while (error != 0);

                if (i<(trabajadores-1)) {
                    data = data + auxStr + "|";
                }
                else
                {
                    data = data + auxStr;
                }
                Console.WriteLine("\n*. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .\n");
            }
            
            ///---------------------------------
            
            foreach(string trabajador in data.Split('|'))
            {
                i = 0;
                foreach(string dato in trabajador.Split(','))
                {
                    switch (i)
                    {
                        case 0:
                            nombre = dato;
                            break;
                        case 1:
                            valorHora = int.Parse(dato);
                            break;
                        case 2:
                            cantidadHoras = int.Parse(dato);
                            break;
                        case 3:
                            antiguedad = int.Parse(dato);
                            break;
                    }
                    i++;
                }

                //-------------------

                totalBruto = (valorHora * cantidadHoras) + (antiguedad * 150);
                totalNeto = totalBruto - ((totalBruto * descuento) / 100);

                Console.WriteLine("*. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .\n" +
                                  "| Nombre: {0,-20} | Antigüedad: {1,-3} | Valor x Hora: ${2,-10}\n" +
                                  "| Horas trabajadas: {5,-3} | Sueldo Bruto: ${3,-10} | Sueldo Neto: ${4,-10}",nombre,antiguedad,valorHora,totalBruto,totalNeto,cantidadHoras);
            }
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej8()
        {
            // Escribir un programa que imprima por consola un triángulo como el siguiente:

            // *
            // ***
            // *****
            // *******
            // *********
            
            int error = 0;
            string auxStr="";
            string symbol = "*";
            int num=0;
            int i;
            int j;

            Console.WriteLine("Dibujando un triángulo rectángulo.\n\n\nPress any key...");
            Console.ReadKey();
            do
            {
                error = 0;
                Console.Write("\n\n\nIngrese la altura del triángulo: ");
                auxStr = Console.ReadLine();
                if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) <= 0)
                {
                    Console.WriteLine("\nError. - Lo ingresado no es un número válido. Debe ser mayor a 0.");
                    error = 1;
                }
            } while (error != 0);
            num = int.Parse(auxStr);
            Console.Write("\n\n");

            for (i = 0; i < num; i++)
            {
                for (j = 0; j < (i + 1); j++)
                {
                    Console.Write(" {0} ", symbol);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }

        ///
        /// ---------------------------------------------------------------------------------------------
        /// ---------------------------------------------------------------------------------------------
        ///

        static void ej9()
        {
            // Escribir un programa que imprima por consola un triángulo como el siguiente:
            //    *
            //   ***
            //  *****
            // *******
            //*********

            int error = 0;
            string auxStr = "";
            string symbol = "*";
            int num = 0;
            int i;
            int j;
            int k;
            int l;

            Console.WriteLine("Dibujando un triángulo rectángulo.\n\n\nPress any key...");
            Console.ReadKey();
            do
            {
                error = 0;
                Console.Write("\n\n\nIngrese la altura del triángulo: ");
                auxStr = Console.ReadLine();
                if (int.TryParse(auxStr, out _) == false || int.Parse(auxStr) <= 0)
                {
                    Console.WriteLine("\nError. - Lo ingresado no es un número válido. Debe ser mayor a 0.");
                    error = 1;
                }
            } while (error != 0);
            num = int.Parse(auxStr);
            Console.Write("\n\n");

            k = 1;
            l = 0;

            for (i = 0; i < num; i++)
            {
                for (j = 0; j < num - k; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < k + l; j++)
                {
                    Console.Write("{0}", symbol);
                }
                for (j = 0; j < num - k; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
                l++;
                k++;
            }
            Console.ReadKey();
        }
    }
}
