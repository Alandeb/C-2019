using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
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
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        private Dolar()
            : this(0, 0)
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
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
            
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos ((d.GetCantidad() * Pesos.GetCotizacion()));
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        // operadores != ==
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            Dolar de = (Dolar)e;
            return d.GetCantidad() == de.GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            Dolar dp = (Dolar)p;
            return d.GetCantidad() == dp.GetCantidad();
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }

        //Operadores  -
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar d1 = (Dolar)e;
            return (d.GetCantidad() - d1.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            return (d.GetCantidad() - d1.GetCantidad());
        }
        // Operadores +
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d1 = (Dolar)e;
            return (d.GetCantidad() + d1.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            return (d.GetCantidad() + d1.GetCantidad());
        }

        #endregion
    }
}
