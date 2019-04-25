using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0, minimo = 0, maximo = 0, promedio = 0;

            string valor;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un Nro: ");
                valor = Console.ReadLine();
                int.TryParse(valor, out nro);

                if (minimo == 0 && maximo == 0)
                {
                    minimo = nro;
                    maximo = nro;
                }

                if (minimo > nro)
                {
                    minimo = nro;
                }
                if (maximo < nro)
                {
                    maximo = nro;
                }

                promedio = promedio + nro;

            }
            promedio = promedio / 5;
            Console.WriteLine("El valor maximo es: " + maximo);
            Console.WriteLine("El valor minimo es: " + minimo);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
