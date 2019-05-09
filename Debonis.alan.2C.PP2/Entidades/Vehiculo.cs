using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;
        
        public string Patente
        {
            get { return patente; }
            set
            {
                if (value.Length == 6)
                {
                    patente = value;
                }
            }
        }
        
        public Vehiculo(string patente)
        {
            ingreso = DateTime.Now.AddHours(-3);

        }

        public new string ToString()
        {
            return string.Format("Patente {0}",Patente);
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("" + ToString());
            cadena.AppendLine("Fecha de ingreso" + ingreso);
            return cadena.ToString();

        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(v1.Equals(v2) && v1.patente == v2.patente)
            {
                return true;
            }
            return false;
        }
        
        public static bool operator !=(Vehiculo v1 , Vehiculo v2)
        {
            return !(v1 == v2);
        }




    }
}
