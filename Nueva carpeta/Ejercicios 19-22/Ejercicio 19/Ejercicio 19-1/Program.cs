using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            #region VARIABLES

            int nro1 = 0,
                nro2 = 0;
            string valor1,
                   valor2,
                   texto;
            bool validar = false;
            long resultado = 0;

            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();

            #endregion

            #region SUMA DE ENTEROS

            Console.WriteLine("SUMA ENTEROS: \n" +
                              "------------ \n");

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un nro: ");
                    valor1 = Console.ReadLine();
                    validar = int.TryParse(valor1, out nro1);
                } while (validar == false);

                do
                {
                    Console.WriteLine("Ingrese un nro: ");
                    valor1 = Console.ReadLine();
                    validar = int.TryParse(valor1, out nro2);
                } while (validar == false);



                resultado = sumador.Sumar((long)nro1, (long)nro2);

                Console.WriteLine("Suma: " + resultado);

                Console.WriteLine("¿Desea seguir sumando? (s/n)");
                valor1 = Console.ReadLine();

            } while (valor1.Equals("s"));



            #endregion

            #region SUMA DE STRING

            Console.Clear();
            Console.WriteLine("STRING: \n" +
                              "------ \n");

            Console.WriteLine("Ingrese un texto: ");
            valor1 = Console.ReadLine();
            Console.WriteLine("Ingrese otro texto: ");
            valor2 = Console.ReadLine();

            texto = sumador2.Sumar(valor1, valor2);

            Console.WriteLine("Texto sumado: " + texto);
            Console.ReadKey();

            #endregion

            #region METODOS EXPLICITOS Y OPERADORES

            Console.Clear();
            Console.WriteLine("CANTIDAD DE SUMAS:\n"  +
                              "-----------------\n"   + 
                              "Suma de enteros: "     + (int)sumador +         // Conversion Explicita
                              "\nSuma de textos: "    + (int)sumador2);        // Conversion Explicita
            Console.WriteLine("Suma total: "          + (sumador + sumador2)); // Suma Operadores
            Console.WriteLine("Suma misma cantidad? " + (sumador | sumador2)); // Comparacion operadores
            
            #endregion

            Console.ReadLine();
        }
    }
}
