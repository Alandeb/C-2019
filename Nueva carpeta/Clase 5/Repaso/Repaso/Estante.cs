using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        #region ATRIBUTOS

        private Producto[] productos;
        private int ubicacionEstante;

        #endregion

        #region CONSTRUCTOR

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Estante()
            :this(0,0)
        {

        }

        #endregion

        #region METODOS

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Ubicacion: " + e.ubicacionEstante);
            foreach(Producto p in e.productos)
            {
                s.AppendLine(Producto.MostrarProducto(p));
            }
            return s.ToString();
        }

        public static bool operator == (Estante e, Producto p)
        {
            if(Object.ReferenceEquals(e.productos, null))
            {
                foreach (Producto p1 in e.productos)
                {
                    if (p1 == p)
                        return true;
                }
                
            }
            return false;

        }

        public static bool operator !=(Estante e, Producto p)
        {
            return (!(e == p));
        }

        public static bool operator +(Estante e, Producto p)
        {
            if((object)p != null){
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    e.productos[i] = null;
                    return e;
                }
            }
            return e;
            
        }

        #endregion
    }
}
