using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            String PARSEINT;
            int Numero,i,j;
            int Resultado;
            Console.Write("INGRESE UN NUMERO: ");
            PARSEINT = Console.ReadLine();
            if(int.TryParse(PARSEINT, out Numero))
            {
                for (i = Numero; i > 1; i--)
                {
                    for (j = i - 1; j > 0; j--)
                    {
                        Resultado = i % j;
                        if (Resultado == 0 && j!=1)
                            break;
                        if (j==2 || i==2)
                            Console.Write("Numero Primo: {0} ",i);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
