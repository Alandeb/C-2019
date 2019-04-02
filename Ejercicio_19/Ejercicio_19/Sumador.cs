using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador()
        {
            this.cantidadSumas = 0;
        }
        public Sumador(int can)
        {
            this.cantidadSumas = can;
        }

        public long Sumar (long a , long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar (string a , string b)
        {
            cantidadSumas++;
            return a + b;
        }

        public static explicit operator int (Sumador s)
        {
            int a;
            a = s.cantidadSumas;
            return a;
        }

        public static long operator + (Sumador s1 , Sumador s2)
        {
            long i;
            i = s1.cantidadSumas + s2.cantidadSumas;
            return i;
        }

        public static   bool operator |(Sumador  s1 , Sumador s2)
        {
            bool r = false;
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                r = true;
            }
            return r;
        }

    }
}
