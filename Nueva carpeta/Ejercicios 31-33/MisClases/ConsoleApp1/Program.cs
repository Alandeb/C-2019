using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisClases;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0;
            Cliente clientes;
            Negocio negocio = new Negocio("Don pepe");
            bool validar = false;
            string salir,
                   nombre;

            do
            {
                Console.WriteLine("Ingrese nombre del cliente: ");
                nombre = Console.ReadLine();
                // Asigno valores
                nro += 1;
                clientes = new Cliente(nro, nombre);
                if(!(negocio == clientes))
                {
                    validar = negocio + clientes;
                    validar = ~negocio;
                }
                Console.WriteLine("¿Desea salir?");
                salir = Console.ReadLine();
            } while (salir.Equals("n"));

            // Mostrar resultado
            Console.WriteLine("Don pepe:\n " +
                              "---------\n");
            Console.WriteLine("Cliente: " + negocio.ClientesPendientes);
            Console.ReadKey();

        }
    }
}
