using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            string c = "Hola";
            string d = "Mundo";
            long a = 10;
            long b = 20;
            Console.WriteLine(suma.Sumar(a, b));
            Console.WriteLine(suma.Sumar(c, d));
            Console.ReadKey();
        }
    }
}
