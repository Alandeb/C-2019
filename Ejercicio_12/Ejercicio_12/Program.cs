using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string parseint,parsechar;
            int numero;
            bool r = true;
            char valor;
        
            do
            {
                Console.Write("Ingrese un numero: ");
                parseint = Console.ReadLine();
                if (int.TryParse(parseint, out numero))
                {
                    Console.Write("¿Continuar?(S\\N) ");
                    parsechar = Console.ReadLine();
                    char.TryParse(parsechar, out valor);
                    r = ValidaS_N.ValidarRespuesta(valor);
                }
            } while (r == true);
        }
    }
}
