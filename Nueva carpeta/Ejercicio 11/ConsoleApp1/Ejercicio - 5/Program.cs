using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio___5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0, 
                flag = 0, 
                sumaAtras = 0, 
                sumaAdelante = 0;
            string valor;
            bool validar = false;

            do
            {
                if (flag == 0)
                    Console.WriteLine("Ingrese cant. nro: ");
                else
                    Console.WriteLine("ERROR!, Ingrese cant. nro: ");
                valor = Console.ReadLine();
                validar = int.TryParse(valor, out nro);
                flag = 1;
            } while (validar == false);

            for(int i = 6; i <= nro; i++)
            { 
                for(int j = 1; j < i; j++)
                {
                    sumaAtras = sumaAtras + j;
                }
                for(int h = i+1; h <= sumaAtras; h++)
                {
                    sumaAdelante = sumaAdelante + h;
                    if (sumaAdelante >= sumaAtras)
                        break;
                }
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Centro numerico: " + i);
                sumaAtras = 0;
                sumaAdelante = 0;
            }
            Console.ReadKey();
        }
    }
}
