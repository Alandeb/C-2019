using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private int dni;
        private int edad;
        private string apellido;
        private string nombre;

        public string Apellido
        {
            get { return apellido; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public int Edad
        {
            get { return edad; }
        }
        public int Dni
        {
            get { return dni; }
        }
        public Persona (string nom , string ape , int edad , int dni)
        {
            this.edad = edad;
            this.dni = dni;
            nombre = nom;
            apellido = ape;
        }
        public virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Nombre: " + Nombre);
            cadena.AppendLine("Apellido: " + Apellido);
            cadena.AppendLine("Dni: " + Dni);
            cadena.AppendLine("Edad: " + Edad);
            return cadena.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
