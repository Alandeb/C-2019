using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_1
{
    class Pesos
    {
        #region ATRIBUTOS

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region CONSTRUCTORES

        private Pesos()
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region METODOS

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro (p.GetCantidad() * Pesos.GetCotizacion());
        }

        // Operadores != ==
        public static bool operator !=(Pesos p, Dolar d)
        {
            
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            Pesos pd = (Pesos)d;
            return (p.GetCantidad() == pd.GetCantidad());
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            Pesos pe = (Pesos)e;
            return (p.GetCantidad() == pe.GetCantidad());
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
        // Operadores -
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos pd = (Pesos)d;
            return new Pesos(p.GetCantidad() - pd.GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos pe = (Pesos)e;
            return new Pesos(p.GetCantidad() - pe.GetCantidad());
        }
        // Operadores +
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos pd = (Pesos)d;
            return new Pesos(p.GetCantidad() + pd.GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos pe = (Pesos)e;
            return new Pesos(p.GetCantidad() + pe.GetCantidad());
        }
        #endregion
    }
}
