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
            string parseint;
            int numero, max = 0, min = 0, promedio = 0, contador = 0;
            bool retorno = false;
            do
            {
                Console.Write("INGRESE UN NUMERO: ");
                parseint = Console.ReadLine();
                if (int.TryParse(parseint, out numero))
                {
                    retorno = Validar.Validacion(numero, -100, 100);
                    if (retorno == true)
                    {
                        contador++;
                        if (contador == 1)
                        {
                            min = numero;
                            max = numero;
                        }
                        if (min > numero)
                        {
                            min = numero;
                        }
                        if (max < numero)
                        {
                            max = numero;
                        }
                        promedio = numero + promedio;
                        if (promedio != 0 && contador == 10)
                        {
                            promedio = promedio / contador;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Error!!!");
                    }
                }
            } while (contador != 10);
            Console.Write("El promedio es {0} , el max {1} y el minimo {2}", promedio, max, min);
            Console.ReadKey();
        }
    }
}
