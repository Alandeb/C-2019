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
            Console.Title = "Ejercicio Nro 02";
            String PARSEINT;
            int Numero, y = 2;
            long Resultado;
            Console.Write("INGRESE UN NUMERO: ");
            PARSEINT = Console.ReadLine();
            do
            {
                if ((int.TryParse(PARSEINT, out Numero)) && Numero > 0)
                {
                    Resultado = (long)Math.Pow((long)Numero, (int)y);
                    Console.Write("El numero es: {0} ", Resultado);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ERROR!! REINGRESE EL NUMERO: ");
                    PARSEINT = Console.ReadLine();
                }
            } while (Numero < 1);

        }
    }
}
