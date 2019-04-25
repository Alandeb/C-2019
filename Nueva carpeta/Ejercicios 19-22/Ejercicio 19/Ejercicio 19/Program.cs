using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesos = 0,
                   dolar = 0,
                   euro  = 0;
            string valor;
            bool validar = false;


            #region CARGA

            do
            {
                Console.WriteLine("Ingrese Pesos: ");
                valor = Console.ReadLine();
                validar = double.TryParse(valor, out pesos);
            } while (validar == false);
            
            do
            {
                Console.WriteLine("Ingrese Dolar: ");
                valor = Console.ReadLine();
                validar = double.TryParse(valor, out dolar);
            } while (validar == false);

            do
            {
                Console.WriteLine("Ingrese Euro: ");
                valor = Console.ReadLine();
                validar = double.TryParse(valor, out euro);
            } while (validar == false);

            #endregion

            #region MUESTRO

            Console.Clear();
            Console.WriteLine("PESOS: \n" +
                              "-----  \n" );
            Console.WriteLine("Valor ingresado: " + pesos);
            Console.WriteLine("Valor en dolares: ");

            #endregion

        }
    }
}
