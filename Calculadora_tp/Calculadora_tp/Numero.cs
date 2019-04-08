using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_tp
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
            double.TryParse(strNumero, out numero);
            return numero;
        }

        public static double operator +(Numero n1 , Numero n2)
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
            return Convert.ToInt64(binario, 2).ToString();
        }


    }
}
