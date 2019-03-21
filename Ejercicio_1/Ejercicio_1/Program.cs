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
            Console.Title = "Ejercicio Nro 01";
            
            int[] Numeros = new int [5];
            string nose;
            int contador = 0;
            int i,otro;
            int min =int.MaxValue;
            int max =int.MinValue;
            for (i = 0; i < 5 ; i++) {
                Console.Write("Coloque los numeros: ");
                nose = Console.ReadLine();
                bool b = int.TryParse(nose, out otro);// esto sirve para parsear un string si es un numero va a tirar true
                // y todo lo que lea en string lo guarda en la variable que defina en out , puedo colocarlo en el if

                if (b) {
                    Numeros[i] = otro;
                    if (i == 0)
                    {
                        min = otro;
                        max = otro;
                    }
                    if (min > otro)
                        min = otro;
                    if (max < otro)
                        max = otro;
                    contador +=  otro;
                 }
                
             }
            contador = contador / i;
            for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Los Numeros son: " + Numeros[i]);
                
                }
            Console.WriteLine("Valor minimo {0} , valor maximo {1} , valor proomedio {2} ", min, max, contador);
            Console.ReadKey();
        }
    }
}
