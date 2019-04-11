using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random num = new Random();
            for (int i = 0; i < 20; i++)
            {
                numeros.Add(num.Next(-1000, 1000));
            }
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();

             numeros.Sort();

            
            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
            Console.Clear();
            numeros=numeros.OrderByDescending(x => x).ToList();
            foreach (int numero in numeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();

        }
    }
}
