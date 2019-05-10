using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get { return descripcion; }
        }

        public double Precio
        {
            get { return precio; }
        }

        public int Stock
        {
            get { return stock; }
            set {
                    if(stock>=0)   
                        stock = value;
                }
        }
        /// <summary>
        /// consturctor con productos
        /// </summary>
        /// <param name="descripcion">string con descripcion</param>
        /// <param name="stock">cantidad del producto</param>
        /// <param name="precio">Precio del producto</param>
        protected Producto(string descripcion , int stock , double precio)
        {
            Stock = stock;
            this.descripcion = descripcion;
            this.precio = precio;
            codigo = Guid.NewGuid();

        }

        public static explicit operator Guid(Producto p)
        {
            Guid g = new Guid(p.codigo.ToString());
            return g;
        }
        /// <summary>
        /// Cadena de caracteres con toda la descripcion
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Descripcion: {0} " , Descripcion);
            cadena.AppendFormat("\nCodigo: {0}" , codigo);
            cadena.AppendFormat("\nPrecio: {0}" , Precio);
            cadena.AppendFormat("\nStock: {0}" , Stock);
            return cadena.ToString();
        }
    }
}
