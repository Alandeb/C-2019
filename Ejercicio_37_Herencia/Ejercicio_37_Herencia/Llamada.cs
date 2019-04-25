using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_Herencia
{
    abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return duracion; }
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public string NroOrigen
        {
            get { return nroOrigen; }
        }


        public Llamada(float duracion , string nroDestino , string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public int OrderPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }else if (llamada1.duracion == llamada2.duracion)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder("");
            cadena.Append("Destino: " + duracion);
            cadena.Append(" Numero Destino: " + nroDestino);
            cadena.Append(" Numero Origen: " + nroOrigen);

            return cadena.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincia,
            Todas
        }


    }
}
