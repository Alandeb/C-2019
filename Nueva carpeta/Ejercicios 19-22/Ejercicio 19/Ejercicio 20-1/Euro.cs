using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_1
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
        // Explicit Implicit
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro p)
        {
            return new Dolar(p.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.GetCantidad() * Euro.GetCotizacion());
        }

        // Operadores != ==

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            Euro ed = (Euro)d;
            return (e.GetCantidad() == ed.GetCantidad());
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            Euro ep = (Euro)p;
            return (e.GetCantidad() == ep.GetCantidad());
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
        // Operador -
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro ed = (Euro)d;
            return new Euro(e.GetCantidad() - ed.GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro ep = (Euro)p;
            return new Euro(e.GetCantidad() - ep.GetCantidad());
        }
        // Operadores +

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro ed = (Euro)d;
            return new Euro(e.GetCantidad() + ed.GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro ep = (Euro)p;
            return new Euro(e.GetCantidad() + ep.GetCantidad());
        }

        #endregion

    }
}

