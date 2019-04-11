using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        static Euro()
        {
            Euro.cotizRespectoDolar = (float)1.16;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;

        }
        public Euro(double cantidad, float cotizRespectoDolar)
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
            Pesos nPesos = new Pesos(d.GetCantidad() / Pesos.GetCotizacion());
            return nPesos;
        }

        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool r = false;
            if (e != d)
            {
                r = true;
            }
            return r;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool r = false;
            double can1 = d.GetCantidad();
            double can2 = e.GetCantidad();// pasar a la misma moneda
            if (can1 == can2)
            {
                r = true;
            }
            return r;
        }

        public static Euro operator +(Euro e, Dolar d) 
        {

            Euro e2;// = new Euro(0);
            e2 = (Euro)d;
            Euro retorno = new Euro( e.GetCantidad() + e2.GetCantidad());
            return retorno;
        }
    }
}
