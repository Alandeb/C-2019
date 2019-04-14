using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        private string SetNumero
        {

            set { numero = ValidarNumero(value); }
        }
        public Numero()
        {
            SetNumero = Convert.ToString(0);
        }
        public Numero(double numero)
        {
            SetNumero = Convert.ToString(numero);
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        private double ValidarNumero(string strNumero)
        {
            double numero;
            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            return 0;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return (n1.numero / n2.numero);
        }

        public string BinarioDecimal(string binario)
        {
            Int64 num = Convert.ToInt64(binario, 2);
            if (num < 0)
            {
                return Convert.ToInt64(binario, 2).ToString();
            }
            else if(num>0)
            {
                return Convert.ToInt64(binario, 2).ToString();
            }
            return "Valor invalido";
        }
        public string DecimalBinario(double numero)
        {
            int numInt = (int)numero;
            if (numInt < 0)
            {
                numInt *= -1;
                return Convert.ToString(numInt, 2);
            }
            else if (numInt>0)
            {
                return Convert.ToString(numInt, 2);
            }

            return "Valor invalido";
        }
        public string DecimalBinario(string numero)
        {
            numero = DecimalBinario(Convert.ToDouble(numero));
            return numero;
        }
    }
}
