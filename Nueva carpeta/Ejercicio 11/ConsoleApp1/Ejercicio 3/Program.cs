using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, nro = 0;
            string valor;
            bool validar = false;

            do
            {
                Console.WriteLine("Ingrese cant. a mostrar: ");
                valor = Console.ReadLine();
                validar = int.TryParse(valor, out nro);
            } while (validar == false);

            for (int i = 2; i < nro; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        cont = cont + 1;
                }
                if (cont <= 2)
                    Console.WriteLine("El nro {0} es primo.", i);
                cont = 0;
            }
            Console.ReadKey();
        }
    }
}
