using System;
using Biblioteca;

namespace EjI08
{
    internal class EjI08
    {
        static void Main(string[] args)
        {
            /*Crear un método estático que reciba una fecha y calcule el número de días que pasaron
            desde esa fecha hasta la fecha actual.Tener en cuenta los años bisiestos.
            Pedir por consola la fecha de nacimiento de una persona(día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.
            Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.*/

            int day = 0;
            int month = 0;
            int year = 0;
            int error = 0;
            int rows = 0;
            int leapYear = 28;

            Console.WriteLine("El tiempo pasa...\n\nPresione una tecla...");
            Console.WriteLine("\nA continuación ingrese una fecha de nacimiento.\nEl programa devolverá la" +
                "cantidad de días pasados desde ese entonces.\n\n\n");
            Console.ReadKey();

            do
            {
                error = 0;
                if (rows == 0)
                {
                    Console.Write("Ingrese el AÑO de nacimiento: ");
                    if ((year = Validador.NumEntry(0)) < 1)
                    {
                        Validador.Error("Error. No puede ser menor a 1.");
                        error = 1;
                    }
                    else
                    {
                        rows++;
                    }
                }
                else if (rows == 1)
                {
                    Console.Write("Ingrese el MES de nacimiento: ");
                    month = Validador.NumEntry(0);
                    if (month>12 || month<1)
                    {
                        Validador.Error("Error. No puede ser menor a 1 ni mayor a 12.");
                        error = 1;
                    }
                    else
                    {
                        rows++;
                    }
                }
                else
                {
                    if (month == 2)
                    {
                        if (DateTime.IsLeapYear(year) == true)
                        {
                            leapYear = 29;
                        }

                        Console.Write("Ingrese un dia entre 1 y {0}: ",leapYear);
                        day = Validador.NumEntry(0);
                        if(day>leapYear || day < 1)
                        {
                            Console.Write("Error. No puede ser menor a 1 ni mayor a {0}.",leapYear);
                            Console.ReadKey();
                            error = 1;
                        }
                        else
                        {
                            rows++;
                        }
                    }
                    else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        Console.Write("Ingrese un dia entre 1 y 31: ");
                        day = Validador.NumEntry(0);
                        if (day > 31 || day < 1)
                        {
                            Validador.Error("Error. No puede ser menor a 1 ni mayor a 31.");
                            error = 1;
                        }
                        else
                        {
                            rows++;
                        }
                    }
                    else if (month == 4 || month == 6 || month == 9 || month == 11){
                        Console.Write("Ingrese un dia entre 1 y 30: ");
                        day = Validador.NumEntry(0);
                        if (day > 30 || day < 1)
                        {
                            Validador.Error("Error. No puede ser menor a 1 ni mayor a 30.");
                            error = 1;
                        }
                        else
                        {
                            rows++;
                        }
                    }
                }
            } while (rows < 3 || error != 0);

            CalcularDias(day, month, year);            
        }

        static void CalcularDias(int day,int month, int year)
        {
            DateTime current = DateTime.Now;

            DateTime bDay = new DateTime(year,month,day);

            Console.WriteLine("La cantidad de dias desde {0} hasta {1} es de: {2}", bDay.ToShortDateString(), current.ToShortDateString(), (int)(current - bDay).TotalDays);
            Console.ReadKey();            
        }
    }
}
