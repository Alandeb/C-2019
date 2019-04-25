using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_Herencia
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        Franja franjaHoraria;
        public Provincial(Franja miFranja,Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen,Franja miFranja, float duracion,string destino) : base(duracion,destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        private float CalcularCosto()
        {
            if(franjaHoraria == Franja.Franja_1)
            {
                return (float)(base.Duracion * 0.99);
            }else if (franjaHoraria == Franja.Franja_2)
            {
                return (float)(base.Duracion * 1.25);

            }else if (franjaHoraria == Franja.Franja_3)
            {
                return (float)(base.Duracion * 0.66);
            }
            return float.MinValue;
        }
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar());
            cadena.Append(" Costo de la llamada: " + CostoLlamada);
            cadena.Append(" Franja: " + franjaHoraria);
            return cadena.ToString();
        }
    }
}
