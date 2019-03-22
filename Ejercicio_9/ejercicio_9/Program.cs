using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nn;
            int ast ;
            int jj = 1 , flag = 0;
            do
            {
                Console.Write("Ingrese la altura de la piramede: ");
                nn = Console.ReadLine();
                if ((int.TryParse(nn, out ast)) && ast > 0)
                {
                    for (int i = 0; i < ast; i++)
                    {
                        for (int j = 0; j < jj; j++)
                        {
                            Console.Write("*");
                        }
                        jj = jj + 2;
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                    flag = 1;
                }
            } while (flag == 0);
          
        }
    }
}
