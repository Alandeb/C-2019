using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
           
            for (int i = 2; i < 8129; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        cont = cont + j;
                }
                if (cont == i)
                    Console.WriteLine("El nro {0} es perfecto.", i);
                cont = 0;
            }
            Console.ReadKey();
        }
    }
}
