using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double nro1 = 0,
                   nro2 = 0;
            string entero;
            bool validar = false;
            
            Console.WriteLine("CALCULADORA: \n" +
                              "-----------\n");
            // Ingreso valores
            do
            {
                Console.WriteLine("Ingrese el primero numero: ");
                entero = Console.ReadLine();
                validar = double.TryParse(entero, out nro1);
            } while (validar == false);

            do
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                entero = Console.ReadLine();
                validar = double.TryParse(entero, out nro2);
            } while (validar == false);

            // ingreso operador
            Console.WriteLine("Ingrese operador (+ , - , * , / ) : ");
            entero = Console.ReadLine();

            // Realizamos el calculo
            Console.WriteLine("El resultado es: " + Calculadora.Calcular(nro1, nro2, entero));
            Console.ReadKey();
            
        }
    }
}
