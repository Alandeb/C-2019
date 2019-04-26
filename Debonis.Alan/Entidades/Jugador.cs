using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private Posicion posicion;
        private float altura;
        private float peso;

        public float Altura
        {
            get { return altura; }
        }

        public float Peso
        {
            get { return peso; }
        }
        
        public Posicion Posicion
        {
            get { return posicion; }
        }

        public Jugador (string nombre, string apellido, int edad, int dni , float peso , float altura , Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar());
            cadena.AppendLine("Altura: "+Altura);
            cadena.AppendLine("Peso: "+Peso);
            cadena.AppendLine("Posicion: "+Posicion);
            return cadena.ToString();
        }

        public override bool ValidarAptitud()
        {
            if (base.Edad <= 40 && ValidarEstadoFisico()==true)
            {
                return true;
            }
            return false;
        }
        public bool ValidarEstadoFisico()
        {
            
            float IMC = Peso / (Altura * Altura);
            if (IMC >= 18.5 || IMC <= 25)
                return true;
            return false;
        }
    }
}
