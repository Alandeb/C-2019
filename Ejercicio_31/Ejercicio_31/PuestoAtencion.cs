using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_31
{
    public enum Puesto
    {
        caja1,
        caja2
    }

    class PuestoAtencion
    {
        private static int numeroActual;
        Puesto puesto;

        public int NumeroActual
        {
            get { return numeroActual; }
        }
        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atencion(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }


    }
}
