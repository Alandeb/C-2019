using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_Herencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;

        public float GananciaPorLocal
        {
            get { }
        }
        public Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            razonSocial = nombreEmpresa;
        }

        private float  CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            return 0;
        }
        
    }
}
