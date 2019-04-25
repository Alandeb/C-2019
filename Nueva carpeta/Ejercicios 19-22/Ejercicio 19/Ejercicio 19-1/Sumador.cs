using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_1
{
    class Sumador
    {
        #region ATRIBUTOS

        private int cantidadSumas;

        #endregion

        #region CONSTRUCTOR

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
            : this(0)
        {

        }

        #endregion

        #region METODOS

        public long Sumar(long a, long b)
        {
            cantidadSumas = cantidadSumas + 1;
            return (long)(((int)a + (int)b));
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas = cantidadSumas + 1;
            return (a + " " + b);
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator + (Sumador s1, Sumador s2)
        {
            return (long)(s1.cantidadSumas + s2.cantidadSumas);
        }

        public static bool operator | (Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas);
        }

        #endregion


    }
}
