using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0,
                flag = 0,
                minimo = 0,
                maximo = 0,
                contador = 0,
                cantMaxima = 0;
            double promedio = 0;
            string valor;
            bool validar;

            do
            {
                // Valido nro
                do
                {
                    if (flag == 0)
                        Console.WriteLine("Ingrese un nro: ");
                    else
                        Console.WriteLine("ERROR!, Ingrese un nro valido: ");
                    flag = 1;
                    valor = Console.ReadLine();
                    validar = int.TryParse(valor, out nro);
                } while (validar == false);
                // Metodo Estatico
                validar = Validacion.Validar(nro, -100, 100);
                if (validar)
                {
                    if (minimo == 0 && maximo == 0)
                    {
                        minimo = nro;
                        maximo = nro;
                    }
                    if (minimo > nro)
                        minimo = nro;
                    if (maximo < nro)
                        maximo = nro;
                    contador = contador + nro;
                    cantMaxima = cantMaxima + 1;
                }
                flag = 0;
            } while (cantMaxima < 10);
            // RESULTADO
            promedio = contador / 10;
            Console.Clear();
            Console.WriteLine("RESULTADO: \n" + 
                              "---------");
            Console.WriteLine("Valor minimo: " + minimo);
            Console.WriteLine("Valor maximo: " + maximo);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();

        }
    }
}
