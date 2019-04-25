using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0,
                temp = 0;
            bool validar = false;
            string text = "*", read;

            do
            {
                Console.WriteLine("Ingrese cantidad: ");
                read = Console.ReadLine();
                validar = int.TryParse(read, out nro);
            } while (validar == false);
            temp = nro;
            for (int i = 0; i < nro; i++)
            {
                temp = temp - 1;
                for(int j = 0; j < temp; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(text);
                text = text + "**";
            }

            Console.ReadKey();
        }
    }
}
