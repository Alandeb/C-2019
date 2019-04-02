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
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador();
            string c = "Hola ",e = "La sobrecarga de operadores ";
            string d = "Mundo", f ="es una MIERDAAAAA";
            long a = 10 , g = 100;
            long b = 20, h =30;
            Console.WriteLine(suma1.Sumar(a, b));
            Console.WriteLine(suma1.Sumar(c, d));
            Console.WriteLine(suma2.Sumar(e, f));
            Console.WriteLine(suma2.Sumar(g, h));
            bool r = suma1 | suma2;
            long m = suma1 + suma2;
            Console.WriteLine("son iguales: {0} , entre las 2 sumas es {1}", r, m);
            Console.ReadKey();
        }
    }
}
