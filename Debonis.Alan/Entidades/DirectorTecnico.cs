using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get { return añosExperiencia; }
            set { añosExperiencia = value; }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExp) : base(nombre, apellido, edad, dni)
        {
            AñosExperiencia = añosExp;
        }

        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar());
            cadena.AppendLine("Años de Experiencia: " + AñosExperiencia);
            return cadena.ToString();
        }

        public override bool ValidarAptitud()
        {
            if (base.Edad < 65 && AñosExperiencia >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
