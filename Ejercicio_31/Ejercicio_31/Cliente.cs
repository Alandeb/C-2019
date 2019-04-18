using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Cliente
    {
        string nombre;
        int numero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
        }
        public Cliente (int numero)
        {
            this.numero = numero;    
        }

        public Cliente (int numero , string nombre)
        {
            this.numero = numero;
            Nombre = nombre;

        }
    }
}
