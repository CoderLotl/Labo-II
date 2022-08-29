using System;

namespace EjI07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y la
            // cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
            // Se pide calcular el importe a cobrar teniendo en cuenta que el total
            // (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle
            // la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.
            // Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y
            // el total a cobrar neto de todos los empleados ingresados.

            string auxStr;
            int trabajadores = -1;
            int i;
            int error = 0;
            string data = "";
            string nombre = "";
            int valorHora = 0;
            int cantidadHoras = 0;
            int antiguedad = 0;
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
            } while (error != 0);

            for (i = 0; i < trabajadores; i++)
            {
                Console.Write("\nIngrese el NOMBRE del trabajador #{0}: ", i + 1);
                auxStr = Console.ReadLine();
                data = data + auxStr + ",";

                do
                {
                    error = 0;
                    Console.Write("\nIngrese el VALOR HORA del trabajador #{0}: ", i + 1);
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
                    Console.Write("\nIngrese la ANTIGÜEDAD del trabajador #{0}: ", i + 1);
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

                if (i < (trabajadores - 1))
                {
                    data = data + auxStr + "|";
                }
                else
                {
                    data = data + auxStr;
                }
                Console.WriteLine("\n*. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .\n");
            }

            ///---------------------------------

            foreach (string trabajador in data.Split('|'))
            {
                i = 0;
                foreach (string dato in trabajador.Split(','))
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
                                  "| Horas trabajadas: {5,-3} | Sueldo Bruto: ${3,-10} | Sueldo Neto: ${4,-10}", nombre, antiguedad, valorHora, totalBruto, totalNeto, cantidadHoras);
            }
            Console.ReadKey();
        }
    }
}
