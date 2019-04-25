using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double x, double y, string operador)
        {
            switch (operador)
            {
                case "+":
                    return (x + y);
                case "-":
                    return (x - y);
                case "*":
                    return (x * y);
                case "/":
                    if (Validar(y))
                        return (x / y);
                    else
                        return 0;
                default:
                    return 0;
            }
        }

        private static bool Validar (double x)
        {
            return (x != 0);
        }
    }
}
