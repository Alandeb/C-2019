using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        #region ATRIBUTOS

        protected float costo;

        #endregion

        #region CONSTRUCTOR

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        #endregion

        #region PROPIEDADES

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Mostar
        /// </summary>
        /// <returns>Devuelve en cadena de texto los valores del Base y la derivada</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Costo de llamada: " + CostoLlamada);
            sb.Append(base.Mostrar());

            return sb.ToString();
        }
        /// <summary>
        /// Calcular costo
        /// </summary>
        /// <returns>Devuelve el costo multiplicado por la duracion</returns>
        private float CalcularCosto()
        {
            return (this.costo * Duracion);
        }

        #endregion
    }
}
