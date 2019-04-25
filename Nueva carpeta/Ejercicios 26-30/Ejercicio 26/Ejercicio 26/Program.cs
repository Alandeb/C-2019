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
            List<int> numeros;
            numeros = new List<int>();
            Random random = new Random();

            for (int i= 0; i < 20; i++){
                numeros.Add(random.Next(-100,100));
            }
            Console.WriteLine("NUMEROS: ");

            // Mostrar como se cargo
            foreach (int nro in numeros)
            {
                Console.WriteLine(nro);
            }

            Console.ReadKey();
            Console.Clear();

            // Mostrar Positivos ordenados en forma decreciente
            numeros.Sort();
            foreach (int nro in numeros)
            {
                if(nro > 0)
                    Console.WriteLine(nro);
            }
            Console.ReadKey();
            Console.Clear();

            // Mostrar negativos
            foreach(int nro in numeros)
            {
                if (nro < 0)
                    Console.WriteLine(nro);
            }
            Console.ReadKey();
        }
    }
}
