using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        #region ATRIBUTOS

        private string codigoDeBarra;
        private string marca;
        private float precio;

        #endregion

        #region CONSTRUCTOR

        public Producto(string codigo, string marca, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        #endregion

        #region Metodos
        // Get
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Codigo de Barras: " + (string)p);
            s.AppendLine("Marca: " + p.marca);
            s.AppendLine("Precio: " + p.precio);
            return s.ToString();
        }
        // Sobrecargas
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return (!(p.GetMarca() == marca));
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (p.GetMarca() == marca);
        }

        public static bool operator != (Producto p1, Producto p2)
        {
            return (!(p1 == p2));
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return ((p1.GetMarca() == p2.GetMarca()) && ((string)p1 == (string)p2));
        }
        #endregion
    }
}
