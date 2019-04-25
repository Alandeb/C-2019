using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Euro
    {
        #region ATRIBUTOS

        private double cantidad;
        private static float cotizRespectoDolar;

        #endregion

        #region CONSTRUCTOR
        private Euro()
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            :this(cantidad)
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
        // Explicit Implicit
        public static implicit operator Euro(double d)
        {
            return d;
        }

        public static explicit operator Dolar(Euro p)
        {
            return (double)(p.GetCantidad() * p.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (double)(e.GetCantidad() * e.GetCotizacion());
        }

        // Operadores != ==

        public static bool operator !=(Euro e, Dolar d)
        {
            return (e.GetCantidad() != (Euro)d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad() == (Euro)d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return (e.GetCantidad() != (Euro)p);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.GetCantidad() == (Euro)p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() != e2.GetCantidad());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
        // Operador -
        public static Dolar operator -(Euro e, Dolar d)
        {
            return (e.GetCantidad() - d.GetCantidad());
        }

        public static Dolar operator -(Euro e, Pesos p)
        {
            return (e.GetCantidad() - p.GetCantidad());
        }
        // Operadores +

        public static Dolar operator +(Euro e, Dolar d)
        {
            return (e.GetCantidad() + d.GetCantidad());
        }

        public static Dolar operator +(Euro e, Pesos p)
        {
            return (e.GetCantidad() + p.GetCantidad());
        }

        #endregion

    }
    }
