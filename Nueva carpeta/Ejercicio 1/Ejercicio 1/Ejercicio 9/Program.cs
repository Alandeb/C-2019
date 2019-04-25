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
            int nro = 0;
            bool validar = false;
            string text = "*", read;

            do
            {
                Console.WriteLine("Ingrese cantidad: ");
                read = Console.ReadLine();
                validar = int.TryParse(read, out nro);
            } while (validar == false);
            
            for (int i = 0; i < nro; i++)
            {
                Console.WriteLine(text);
                text = text + "**";
            }
            
            Console.ReadKey();
        }
    }
}
