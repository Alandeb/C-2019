using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    

    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        #region ATRIBUTOS

        protected Franja franjaHoraria;

        #endregion

        #region CONSTRUCTOR

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
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
        /// Calcular costo
        /// </summary>
        /// <returns>Retorna el valor del costo multiplicado por duracion en base a la franja horaria</returns>
        private float CalcularCosto()
        {
            if (this.franjaHoraria.Equals("Franja_1"))
                return (this.Duracion * (float)0.99);
            if (this.franjaHoraria.Equals("Franja_2"))
                return (this.Duracion * (float)1.25);
            else 
                return (this.Duracion * (float)0.66);
        }
        /// <summary>
        /// Mostrar
        /// </summary>
        /// <returns>Retorna una cadena de texto con la franja horaria y los valores del base.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Franja horaria: " + this.franjaHoraria.ToString());
            sb.Append(base.Mostrar());

            return sb.ToString();
        }

        #endregion

    }
}
