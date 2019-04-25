using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        #region ATRIBUTOS

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region CONSTRUCTOR

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region PROPIEDADES

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }


        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Calcula la ganancia
        /// </summary>
        /// <param name="tipo"> Recibe el tipo de llamada </param>
        /// <returns> Devuelve el costo segun el tipo de llamada (LOcal; Provincial; Todas) </returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float contador = 0;

            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                if(tipo == TipoLlamada.Local && (llamada is Local))
                    contador += ((Local)llamada).CostoLlamada;
                if(tipo == TipoLlamada.Provincial && (llamada is Provincial))
                    contador += ((Provincial)llamada).CostoLlamada;
                if(tipo == TipoLlamada.Todas)
                {
                    if(llamada is Local)
                        contador += ((Local)llamada).CostoLlamada;
                    if(llamada is Provincial)
                        contador += ((Provincial)llamada).CostoLlamada;
                }
            }

            return contador;
        }
        /// <summary>
        /// Muestra todo los datos
        /// </summary>
        /// <returns> Retorna una cadena de texto de los datos de las llamadas, razon social y los costos</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Razon social: " + this.razonSocial);
            sb.Append("Ganancia Total: " + GananciasPorTotal);
            sb.Append("Ganancia Local: " + GananciasPorLocal);
            sb.Append("Ganancia Provincial: " + GananciasPorProvincial);
            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                sb.Append(llamada.Mostrar());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Ordena las llamadas por duracion.
        /// </summary>
        public void OrdenarLlamadas()
        {
            Llamada auxLlamada;
            for (int i = 0; i < this.listaDeLlamadas.Count; i++)
            {
                for(int j = i+1; j < this.listaDeLlamadas.Count; j++)
                {
                    if((Llamada.OrdenarPorDuracion(this.listaDeLlamadas[i],this.listaDeLlamadas[j])) == 1)
                    {
                        auxLlamada = this.listaDeLlamadas[i];
                        this.listaDeLlamadas[i] = this.listaDeLlamadas[j];
                        this.listaDeLlamadas[j] = auxLlamada;
                    }
                }
            }
        }

        #endregion

    }
}
