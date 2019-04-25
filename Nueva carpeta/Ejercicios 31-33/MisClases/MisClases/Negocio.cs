using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Negocio
    {
        #region ATRIBUTOS

        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #endregion

        #region CONSTRUCTOR

        private Negocio()
        {
            this.caja = new PuestoAtencion(Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region PROPIEDADES

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool validar = false;
                foreach(Cliente c in this.clientes)
                {
                    if (Object.ReferenceEquals(c, value))
                    {
                        validar = true;
                        break;
                    }
                }
                if (!validar)
                {
                    this.clientes.Enqueue(value);
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        #endregion

        #region METODOS

        public static bool operator +(Negocio n, Cliente c)
        {
           
            if(n.Cliente != c)
            {
                n.Cliente = c;
                return true;
            }
           return false;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente c2 in n.clientes)
            {
                if (c2 == c)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return (n.caja.Atender(n.Cliente));
        }

        #endregion
    }
}
