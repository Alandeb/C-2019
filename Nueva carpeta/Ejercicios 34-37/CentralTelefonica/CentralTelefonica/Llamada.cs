using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public class Llamada
    {
        #region ATRIBUTOS

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region CONSTRUCTOR

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion

        #region PROPIEDADES

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Ordena las llamadas por Duracion
        /// </summary>
        /// <param name="llamada1">Recibe la Llamada 1</param>
        /// <param name="llamada2">Recibe la Llamada 2</param>
        /// <returns>Retorna 1 si la llamada 1 es mayor al 2, caso contrario retorna 0</returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            if (llamada1.Duracion < llamada2.Duracion)
                return -1;
            else
                return 0;
        }
        /// <summary>
        /// Mostrar
        /// </summary>
        /// <returns>Devuelve en cadena de texto los valores del Base</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Duracion: " + this.duracion);
            sb.Append("Numero de Destino: " + this.nroDestino);
            sb.Append("Numero de Origen: " + this.nroOrigen);

            return sb.ToString();
        }

        #endregion
    }
}
