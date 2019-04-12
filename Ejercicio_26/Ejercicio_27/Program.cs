using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27_Q
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numerosq = new Queue<int>();
            Random num = new Random();
            for (int i = 0; i < 20; i++)
            {
                numerosq.Enqueue(num.Next(-1000, 1000));
            }
            foreach (int numero in numerosq)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();

            List<int> numerosq1 =numerosq.ToList().OrderBy(x => x).ToList();


            foreach (int numero in numerosq1)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
            Console.Clear();
            List<int> numerosq2 = numerosq.ToList().OrderByDescending(x => x).ToList();
            foreach (int numero in numerosq2)
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
