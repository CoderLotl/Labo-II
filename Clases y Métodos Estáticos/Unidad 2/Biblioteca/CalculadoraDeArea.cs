using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado){                      
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double basex, double altura)
        {
           return basex*altura*0.5;
        }

        public static double CalcularAreaCirculo(double radio)
        {        
            return radio*Math.PI;
        }

    }
}
