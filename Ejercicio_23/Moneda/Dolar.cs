using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;

        }
        public Dolar(double cantidad, float cotizRespectoDolar)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizRespectoDolar;

        }
        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro nEuro = new Euro(d.cantidad * (Dolar.cotizRespectoDolar / Euro.GetCotizacion()));

            return nEuro;
        }
        public static explicit operator Pesos(Dolar d)
        {
            Pesos nPesos = new Pesos(d.cantidad * Pesos.GetCotizacion());
            return nPesos;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }
    }

    
    
}
