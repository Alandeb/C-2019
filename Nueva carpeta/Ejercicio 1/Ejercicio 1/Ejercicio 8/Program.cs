using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, antiguedad = 0, cantHoras = 0;
            string nombre, valor;
            bool validar = false;

            // Ingresar valores
            do { 
            Console.WriteLine("Ingrese valor horas: ");
            valor = Console.ReadLine();
            validar = int.TryParse(valor, out horas);
            } while (validar == false);

            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();

            do { 
            Console.WriteLine("Ingrese antiguedad: ");
            valor = Console.ReadLine();
            validar = int.TryParse(valor, out antiguedad);
            } while (validar == false);

            do { 
            Console.WriteLine("Cantidad Horas trabajadas: ");
            valor = Console.ReadLine();
            validar = int.TryParse(valor, out cantHoras);
            } while (validar == false);

            // Calcular recibo
            double bruto = (horas * cantHoras) + antiguedad;
            double desc = bruto * 0.13;
            double neto = bruto - desc;
            // Mostrar Recibo
            Console.WriteLine("");
            Console.WriteLine("Recibo:");
            Console.WriteLine("-------");
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Antiguedad: " + antiguedad);
            Console.WriteLine("Valor horas: " + horas);
            Console.WriteLine("Total bruto: " + bruto);
            Console.WriteLine("total neto: " + neto);

            Console.ReadKey();
        }
    }
}
