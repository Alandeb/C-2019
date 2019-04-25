using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Cliente
    {
        #region ATRIBUTOS

        private string nombre;
        private int numero;

        #endregion

        #region CONSTRUCTOR

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre)
            :this(numero)
        {
            Nombre = nombre;
        }

        #endregion

        #region PROPIEDADES

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = (value);
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Compara clientes
        /// </summary>
        /// <param name="cl1">Cliente nro 1</param>
        /// <param name="cl2">Cliente nro 2</param>
        /// <returns>Si son iguales devuelve verdadero, caso contrario, falso.</returns>
        public static bool operator == (Cliente cl1, Cliente cl2)
        {
            return (cl1 == cl2);
        }

        public static bool operator !=(Cliente cl1, Cliente cl2)
        {
            return !(cl1 == cl2);
        }

        #endregion
    }
}
