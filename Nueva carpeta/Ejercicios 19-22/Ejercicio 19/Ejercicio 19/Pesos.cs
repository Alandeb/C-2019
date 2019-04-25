using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
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

        public float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return d;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return (p.GetCantidad() * p.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (p.GetCantidad() * p.GetCotizacion());
        }

        // Operadores != ==
        public static bool operator !=(Pesos p, Dolar d)
        {
            return (p.GetCantidad() != (Pesos)d);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p.GetCantidad() == (Pesos)d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return (p.GetCantidad() != (Pesos)e);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return (p.GetCantidad() == (Pesos)e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() != p2.GetCantidad());
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
        // Operadores -
        public static Dolar operator -(Pesos p, Dolar d)
        {
            return (p.GetCantidad() - d.GetCantidad());
        }

        public static Dolar operator -(Pesos p, Euro e)
        {
            return (p.GetCantidad() - e.GetCantidad());
        }
        // Operadores +
        public static Dolar operator +(Pesos p, Dolar d)
        {
            return (p.GetCantidad() + d.GetCantidad());
        }

        public static Dolar operator +(Pesos p, Euro e)
        {
            return (p.GetCantidad() + e.GetCantidad());
        }
        #endregion
    }
}
