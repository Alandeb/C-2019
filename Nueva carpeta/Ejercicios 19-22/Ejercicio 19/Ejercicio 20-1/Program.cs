using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dolar dolar = new Dolar((double)20,(float)1);
            Euro euro = new Euro((double)35, (float)1.14);
            Pesos pesos = new Pesos((double)135, (float)38.8);

            Console.WriteLine("DOLAR / PESOS / EUROS: \n" +
                              "----------------------\n");
            Console.WriteLine("Dolar ingresado: " + dolar.GetCantidad());
            Console.WriteLine("Euro ingresado: " + euro.GetCantidad());
            Console.WriteLine("Peso ingresado: " + pesos.GetCantidad());

            Console.WriteLine("\nCONVERSION: \n" +
                              "-----------\n");
            Console.WriteLine("- Conversion a Pesos: ");
            // Dolar A Pesos
            Console.WriteLine("Dolar a Pesos: " + ((Pesos)dolar).GetCantidad());
            // Euro a Pesos
            Console.WriteLine("Euro a Pesos: " + ((Pesos)((Dolar)euro)).GetCantidad());

            Console.WriteLine("\n- Conversion a Dolar: ");
            // Pesos a Dolar
            Console.WriteLine("Pesos a Dolar: " + ((Dolar)pesos).GetCantidad());
            // Euro a Dolar
            Console.WriteLine("Euro a Dolar: " + ((Dolar)euro).GetCantidad());

            Console.WriteLine("\n- Conversion a Euro: ");
            Console.WriteLine("Pesos a Euro: " + ((Euro)((Dolar)pesos)).GetCantidad());
            Console.WriteLine("Dolar a Euro: " + ((Euro)dolar).GetCantidad());

            Console.ReadKey();


        }
    }
}
