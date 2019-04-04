using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto (string marca, string codigo , float precio)
        {
            codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }
        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static string MostrarProducto(Producto p)
        {
            return string.Format("El codigo de barra es {0} la marca es {1} " +
                "y el precio es {2} ", p.codigoDeBarra, p.marca, p.precio);
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool r = false;
            if (p.marca != marca)
            {
                r = true;
            }
            return r;
        }
        public static bool operator ==(Producto p, string marca)
        {
            return (!(p != marca));//uso de operador sobrecargado
        }
        public static bool operator !=(Producto p, Producto p2)
        {
            bool r = false;
            if ((p.marca != p2.marca) &&(p.codigoDeBarra != p2.codigoDeBarra))
            {
                r = true;
            }
            return r;
        }
        public static bool operator ==(Producto p, Producto p2)
        {
            return (!(p != p2));//uso de operador sobrecargado
        }
    }
}
