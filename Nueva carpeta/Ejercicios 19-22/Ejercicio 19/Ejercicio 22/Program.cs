using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            double nro = 0;
            bool validar = false;

            #region CARGO NROS DECIMAL BINARIO

            do
            {
                Console.WriteLine("Ingrese un nro decimal: ");
                valor = Console.ReadLine();
                validar = double.TryParse(valor, out nro);
            } while (validar == false);

            Console.WriteLine("Ingrese un nro Binario: ");
            valor = Console.ReadLine();

            NumeroDecimal nroDecimal = nro; // Conversion Implicita
            NumeroBinario nroBinario = valor; // Conversiòn Implicita

            #endregion

            #region MUESTRO RESULTADO

            Console.WriteLine("Numero decimal ingresado: " + nroDecimal.numero);
            Console.WriteLine("Numero binario ingresado: " + nroBinario.numero);
            
            Console.WriteLine("\nDE DECIMAL A BINARIO: \n" +
                              "--------------------\n");
            Console.WriteLine("DE DECIMAL A BINARIO: " + (string)nroDecimal);
            Console.WriteLine("SUMA DE DECIMAL Y BINARIO {0} + {1} = {2} en Decimal ", nroDecimal.numero, nroBinario.numero, (nroDecimal + nroBinario));
            Console.WriteLine("RESTA DE DECIMAL Y BINARIO {0} - {1} = {2} en Decimal ", nroDecimal.numero, nroBinario.numero, (nroDecimal - nroBinario));
            Console.WriteLine("SON IGUALES {0} = {1} Resultado --> {2}   ", nroDecimal.numero, nroBinario.numero, (nroDecimal == nroBinario));
            Console.WriteLine("SON DISTINTOS {0} != {1} Resultado --> {2}   ", nroDecimal.numero, nroBinario.numero, (nroDecimal != nroBinario));
            Console.WriteLine("\nDE BINARIO A DECIMAL: \n" +
                              "--------------------\n");
            Console.WriteLine("DE NRO BINARIO A DECIMAL: " + (double)nroBinario);
            Console.WriteLine("SUMA DE BINARIO Y DECIMAL {0} + {1} = {2} en Binario ", nroBinario.numero, nroDecimal.numero, (nroBinario + nroDecimal));
            Console.WriteLine("RESTA DE BINARIO Y DECIMAL {0} - {1} = {2} en Binario ", nroBinario.numero, nroDecimal.numero, (nroBinario - nroDecimal));
            Console.WriteLine("SON IGUALES {0} = {1} Resultado -->  {2}  ", nroBinario.numero, nroDecimal.numero, (nroBinario == nroDecimal));
            Console.WriteLine("SON DISTINTOS{0} != {1} Resultado -->  {2}  ", nroBinario.numero, nroDecimal.numero, (nroBinario != nroDecimal));
            Console.ReadKey();

            #endregion

        }
    }
}
