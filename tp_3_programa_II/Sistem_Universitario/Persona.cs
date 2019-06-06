using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Universitario
{
    public abstract class Persona
    {
        public enum Enacionalidad
        {
            Argentino,
            Extranjero
        }
        private string apellido;
        private int dni;
        private Enacionalidad nacionalidad;
        private string nombre;

        abstract public string Apellido { get; set; }
        
    }
}
