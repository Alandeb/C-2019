using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0, fin = 0;

            Console.WriteLine("Ingrese año inicio: ");
            string año = Console.ReadLine();
            bool validar = int.TryParse(año, out inicio);
            while (validar == false)
            {
                Console.WriteLine("ERROR!, Ingrese año inicio: ");
                año = Console.ReadLine();
                validar = int.TryParse(año, out inicio);
            }
            Console.WriteLine("Ingrese año fin: ");
            año = Console.ReadLine();
            validar = int.TryParse(año, out fin);
            while (validar == false)
            {
                Console.WriteLine("ERROR!, Ingrese año Fin: ");
                año = Console.ReadLine();
                validar = int.TryParse(año, out fin);
            }

            for(int i = inicio; i <= fin; i++)
                if (i % 4 == 0)
                    Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
