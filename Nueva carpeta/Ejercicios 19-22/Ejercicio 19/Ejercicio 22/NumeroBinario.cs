using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class NumeroBinario
    {
        #region ATRIBUTOS

        public string numero;

        #endregion

        #region CONSTRUCTOR

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        #endregion

        #region METODOS
        // Explicito
        public static explicit operator double(NumeroBinario numeroBinario)
        {
            return numeroBinario.BinarioDecimal(numeroBinario.numero);
        }
        // Implicito
        public static implicit operator NumeroBinario(string binario)
        {
            return new NumeroBinario(binario);
        }
        // Conversor
        private double BinarioDecimal(string numeroBinario)
        {
            double cont = 0, nro = 0;

            int nro2 = 0;

            for (int i = numeroBinario.Length; i > 0; i--)
            {
                if (numeroBinario[i - 1].Equals('1'))
                {
                    cont = Math.Pow(2, nro2);
                }
                nro = nro + cont;
                nro2 = nro2 + 1;
                cont = 0;
            }

            return nro;
        }
        // OPERADORES + -
        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double b = (double)numeroBinario;
            b = b + numeroDecimal.numero;
            return numeroDecimal.DecimalBinario(b);
        }
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double b = (double)numeroBinario;
            b = b - numeroDecimal.numero;
            return numeroDecimal.DecimalBinario(b);
        }
        // OPERADORES ==
        public static bool operator == (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double b = (double)numeroBinario;
            return (b == numeroDecimal.numero);
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double b = (double)numeroBinario;
            return (b != numeroDecimal.numero);
        }

        #endregion
    }
}
