using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = (float)0.02609;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;

        }
        public Pesos(double cantidad, float cotizRespectoDolar )
        {
            this.cantidad = cantidad;
            Pesos.cotizRespectoDolar = cotizRespectoDolar;

        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static explicit operator Dolar (Pesos p)
        {
            Dolar nDolar = new Dolar(p.cantidad* p.);
        }
    }
}
