using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nn;
            int ast;
            int jj = 1, flag = 0;
            char asterisco = '*';
            int despl = 20;
            do
            {
                Console.Write("Ingrese la altura de la piramede: ");
                nn = Console.ReadLine();
                if ((int.TryParse(nn, out ast)) && ast > 0)
                {
                    for (int i = 0; i < ast; i++)
                    {
                        int prueba = despl;
                        for (int j = 0; j < jj; j++)
                        {
                            prueba++;
                            if (j == 0)
                                prueba++;
                            Console.Write("{0,"+prueba+"}", asterisco);
                            prueba = 0;
                            
                        }
                        despl = despl - 2;
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
