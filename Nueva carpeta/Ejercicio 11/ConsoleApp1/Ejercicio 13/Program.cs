using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            double num = 0;
            string convertInt;
            bool validar = false;

            do
            {
                if (flag == 0)
                    Console.WriteLine("Ingrese un nro: ");
                else
                    Console.WriteLine("ERROR!, Ingrese un nro valido: ");
                flag = 1;
                convertInt = Console.ReadLine();
                validar = Double.TryParse(convertInt, out num);
            } while (validar == false);

            convertInt = Conversor.DecimalBinario(num);
            Console.WriteLine(convertInt);
            Console.WriteLine(Conversor.BinarioDecimal(convertInt));
            Console.ReadKey();
        }
    }
}
