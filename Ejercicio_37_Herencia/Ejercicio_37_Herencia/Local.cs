using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_Herencia
{
    class Local : Llamada 
    {
        protected float costo;

        public float CostoLlamada
        {
            get { return CalucularCosto(); }
        }

        public Local(Llamada llamada, float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local (string destino,float duracion ,string origen,float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar());
            cadena.Append(" Costo De La Llamada: "+CostoLlamada);
            return cadena.ToString();
        }
            
        private float CalucularCosto()
        {
            return base.Duracion * costo;
        }
        

    }
}
