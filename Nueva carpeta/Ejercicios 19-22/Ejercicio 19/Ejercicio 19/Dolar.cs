using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Dolar
    {
        #region ATRIBUTOS

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region CONSTRUCTORES
        
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion)
            :this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        private Dolar()
            :this(0,0)
        {

        }
        #endregion

        #region METODOS

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return (double)(d.GetCantidad() * d.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return (double)(d.GetCantidad() * d.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return d;
        }
        // operadores != ==
        public static bool operator !=(Dolar d, Euro e)
        {
            return d.cantidad != (Dolar)e;
        }
        public static bool operator == (Dolar d, Euro e)
        {
            return d.cantidad == (Dolar)e;
        }

        public static bool operator != (Dolar d, Pesos p)
        {
            return d.cantidad != (Dolar)p;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.cantidad == (Dolar)p;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return d1.cantidad != d2.cantidad;
        }

        public static bool operator == (Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        //Operadores  -
        public static Dolar operator -(Dolar d, Euro e)
        {
            return (d.GetCantidad() - e.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return (d.GetCantidad() - p.GetCantidad());
        }
        // Operadores +
        public static Dolar operator +(Dolar d, Euro e)
        {
            return (d.GetCantidad() + e.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return (d.GetCantidad() + p.GetCantidad());
        }

        #endregion

    }
}
