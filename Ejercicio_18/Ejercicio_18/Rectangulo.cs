using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1 = new Punto(2, 2);
        private Punto vertice2 = new Punto(5, 2);
        private Punto vertice3 = new Punto(2, 4);
        private Punto vertice4 = new Punto(4, 5);

        public Rectangulo(Punto vertice1, Punto vertice2)
        {
            Math.Abs(vertice1, vertice2);
        }
    }
}
