using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Rectangulo
    {
        // Atributos
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        // Constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = vertice1;
            this.vertice3 = vertice3;
            this.vertice4 = vertice3;
        }

        // Metodos

        public float Area()
        {
            return this.area;
        }

        public float Perimetro()
        {
            return this.perimetro;
        }

    }
}
