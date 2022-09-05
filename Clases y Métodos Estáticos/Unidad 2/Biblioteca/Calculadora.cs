using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        public static string Calcular(int num1, int num2, char str)
        {

            string total = "";

            if (Validar(num2, str) != false)
            {
                switch (str)
                {
                    case '+':
                        total = Convert.ToString(num1 + num2);
                        break;
                    case '-':
                        total = Convert.ToString(num1 - num2);
                        break;
                    case '*':
                        total = Convert.ToString(num1 * num2);
                        break;
                    case '/':
                        total = Convert.ToString(num1 / num2);
                        break;
                }
            }
            else
            {
                total = "ERROR. - No se puede dividir por 0.";
            }

            return total;
        }

        private static bool Validar(int num2, char str)
        {

            return (num2 == 0 && str == '/') ? false : true;
        }
    }
}