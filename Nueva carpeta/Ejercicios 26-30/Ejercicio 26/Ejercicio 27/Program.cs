using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int salir = 0;

            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();

            Random random = new Random();

            for(int i = 0; i  < 20; i++)
            {
                queue.Enqueue(random.Next(-100, 100));
                stack.Push(random.Next(-100, 100));
            }

            // Resultados:
            Console.WriteLine("RESULTADOS: \n" +
                              "----------\n");

            do
            {
                if (salir == 0)
                {
                    Console.WriteLine("Cola: ");
                    Console.WriteLine("Decreciente...");
                    foreach(int nro in queue)
                    {
                        Console.WriteLine(nro);
                    }
                    Console.ReadKey();
                }
                if(salir == 1)
                {
                    Console.WriteLine("Pila: ");
                    Console.WriteLine("Decreciente...");
                    foreach(int nro in stack)
                    {
                        Console.WriteLine(nro);
                    }
                    Console.ReadKey();
                }
                salir += 1;

            } while (salir < 2);
        }
    }
}
