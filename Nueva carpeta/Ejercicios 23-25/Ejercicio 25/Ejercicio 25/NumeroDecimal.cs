using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class NumeroDecimal
    {
        #region ATRIBUTOS

        public double numero;

        #endregion

        #region CONSTRUCTOR

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        #endregion

        #region METODOS

        // Explicito
        public static explicit operator string(NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalBinario(numeroDecimal.numero);
        }
        // Implicito

        public static implicit operator NumeroDecimal(double decima)
        {
            return new NumeroDecimal(decima);
        }

        // Conversor

        public string DecimalBinario(double numeroDecimal)
        {
            string binario = "";
            int temp = 0;
            while (numeroDecimal > 0)
            {
                temp = (int)numeroDecimal % 2;
                if (temp == 0)
                    binario = "0" + binario;
                if (temp == 1)
                    binario = "1" + binario;
                numeroDecimal = (int)numeroDecimal / 2;
            }
            return binario;
        }

        // OPERADORES + - 
        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            double b = (double)numeroBinario;
            b = numeroDecimal.numero + b;
            return b;
        }

        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            double b = (double)numeroBinario;
            b = numeroDecimal.numero - b;
            return b;
        }
        // OPERADORES ==
        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            double b = (double)numeroBinario;
            return (numeroDecimal.numero == b);
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            double b = (double)numeroBinario;
            return (numeroDecimal.numero != b);
        }
        #endregion
    }
}
