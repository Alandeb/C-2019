using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int procentajeIva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            procentajeIva = 21;
        }

        internal Venta(Producto producto,  int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            producto.Stock = producto.Stock - cantidad;
            fecha = DateTime.Now;
            precioFinal=CalcularPrecioFinal(producto.Precio, cantidad);
        }
        public static double CalcularPrecioFinal(double precioUnidad , int cantidad)
        {
            double procentaje = 1 + (procentajeIva / 100);
            return (precioUnidad * cantidad) * procentaje;
        }
        internal DateTime Fecha
        {
            get { return fecha; }
        }
        public string ObtenerDescripcionBreve()
        {
            return string.Format("Fecha: {0} , Descripcion: {1} , Precio Final: {2}", fecha, producto.Descripcion, precioFinal);
        }

    }
}
