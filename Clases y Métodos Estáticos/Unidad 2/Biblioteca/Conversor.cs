using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string num = "";
            int numAux = 0;

            while (numeroEntero > 0)
            {
                numAux = (numeroEntero % 2);
                num = numAux.ToString() + num;
                numeroEntero /= 2;
            }
            return num;
        }

        ///-----------------------------------------

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {

            int digit = 0;
            int decimalNumber = 0;
            int base1 = 1;

            while (numeroEntero > 0)
            {
                digit = numeroEntero % 10;
                numeroEntero = numeroEntero / 10;
                decimalNumber += digit * base1;
                base1 *= 2;
            }

            return decimalNumber;
        }
    }
}