using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MisClases
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }

    public class PuestoAtencion
    {
        #region ATRIBUTOS

        

        private static int numeroActual;
        private Puesto puesto;

        #endregion

        #region CONSTRUCTOR

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion

        #region PROPIEDADES

        public int NumeroActual
        {
            get
            {
                numeroActual += 1;
                return numeroActual;
            }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Simulaciòn de atenciòn al cliente
        /// </summary>
        /// <param name="cli">Recibe como parametro el cliente que sera atendido</param>
        /// <returns>Devuelve verdadero si es atendido, caso contrario, falso.</returns>

        public bool Atender(Cliente cli)
        {
            if(!Object.ReferenceEquals(cli, null))
            {
                Thread.Sleep(1);
                return true;
            }
            return false;
        }

        #endregion
    }
}
