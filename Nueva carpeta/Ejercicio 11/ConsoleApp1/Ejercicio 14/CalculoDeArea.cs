using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double nro)
        {
            return (Math.Pow(nro, nro));
        }

        public static double CalcularTriangulo(double x, double y)
        {
            return ((x / 2) * y);
        }

        public static double CalcularCirculo(double x)
        {

            return ((Math.Pow(x, 2)) * 3.14159);
        }
    }
}
