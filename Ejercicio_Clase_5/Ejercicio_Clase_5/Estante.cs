using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private Estante(int capacidad)
        {  // siempre que tenga un array hago esto 
            this.productos = new Producto[capacidad];
        }   // siempre que tenga un constructor privado lo llamo de la misma manera
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string mostrar= "";
            foreach (Producto p in e.productos)
            {
                if (!(object.ReferenceEquals(p, null)))
                    mostrar += Producto.MostrarProducto(p) + "\n";
            }
            return mostrar;
        }
        public static bool operator ==(Estante e , Producto p)
        {
            
            bool r = false ;
            foreach (Producto p2 in e.productos)
            {
                if (!(object.ReferenceEquals(p2, null)) && !(object.ReferenceEquals(p, null)) && p2 == p )
                {
                    r = true;
                    break;
                }
            }
            return r;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return (!(e == p));
           
        }
       
        public static bool operator +(Estante e,Producto p)
        {
            if (!(e == p))         
            {
                for(int i =0; i<e.productos.Length; i++)
                {
                    if (object.ReferenceEquals(e.productos[i], null))
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
    }
}
