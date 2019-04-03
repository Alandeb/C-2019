using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        static Euro()
        {
            Euro.cotizRespectoDolar = (float)1.16;
        }
        public Euro (double cantidad)
        {
            this.cantidad = cantidad;

        }
        public Euro(double cantidad, float cotizRespectoDolar )
        {
            this.cantidad = cantidad;
            Euro.cotizRespectoDolar = cotizRespectoDolar;

        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar NDolar = new Dolar(e.cantidad * Euro.GetCotizacion());
            return NDolar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar d = new Dolar(0);
            d = (Dolar)e;//Invocar explicitamente
            Pesos nPesos = new Pesos(d.GetCantidad()/Pesos.GetCotizacion());
            return nPesos;
        }
       


    }
}
