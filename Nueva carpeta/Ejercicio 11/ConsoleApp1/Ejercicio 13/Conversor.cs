using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double c)
        {
            string binario="";
            int temp = 0;
            do
            {
                binario = (int)(c % 2) + binario;
                c = (int)c / 2;
            } while (c > 0);
            return binario;
        }

        public static double BinarioDecimal(string binario)
        {
            double cont = 0, nro = 0;
            int nro2 = 0;

             for (int i = binario.Length; i > 0; i--)
            {
                if (binario[i-1].Equals('1'))
                {
                    cont = Math.Pow(2, nro2);
                }
                nro = nro + cont;
                nro2 = nro2 + 1;
                cont = 0;
            }

            return nro;
        }



    }
}
