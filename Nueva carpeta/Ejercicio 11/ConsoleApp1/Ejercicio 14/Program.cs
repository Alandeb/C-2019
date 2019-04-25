using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0,
                y = 0,
                z = 0;
            string entero;
            bool validar = false;

            do
            {
                Console.WriteLine("Ingrese x: ");
                entero = Console.ReadLine();
                validar = int.TryParse(entero, out x);
            } while (validar == false);

            do
            {
                Console.WriteLine("Ingrese y: ");
                entero = Console.ReadLine();
                validar = int.TryParse(entero, out y);
            } while (validar == false);

            do
            {
                Console.WriteLine("Ingrese z: ");
                entero = Console.ReadLine();
                validar = int.TryParse(entero, out z);
            } while (validar == false);

            Console.WriteLine(CalculoDeArea.CalcularCuadrado(x));
            Console.WriteLine(CalculoDeArea.CalcularCirculo(x));
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(x,y));
            Console.ReadKey();
        }
    }
}
