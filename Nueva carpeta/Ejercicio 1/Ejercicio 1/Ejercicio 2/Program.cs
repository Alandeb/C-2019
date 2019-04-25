using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int flag = 0;
            double cuadrado, cubo, nro;
            string valor;
            do
            {
                if (flag == 0)
                {
                    Console.WriteLine("Ingrese un nro: ");
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

                valor = Console.ReadLine();
                double.TryParse(valor, out nro);
            } while (nro < 1);

            cuadrado = Math.Pow(nro, 2);
            cubo = Math.Pow(nro, 3);
            Console.Write("El nro cuadrado es {0} y el nro cubo es {1}",cuadrado, cubo);
            Console.ReadKey();

        }
    }
}
