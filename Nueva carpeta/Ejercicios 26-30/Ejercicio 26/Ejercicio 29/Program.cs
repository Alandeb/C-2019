using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(5, "Equipo Chico");
            int cantidad = 0,
                dni = 0,
                totalGoles = 0,
                totalPartidos = 0;
            string nombre;
            bool validar = false;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese DNI: ");
                    validar = int.TryParse(Console.ReadLine(), out dni);
                } while (!validar);

                Console.WriteLine("Ingrese Nombre: ");
                nombre = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese Total de Goles: ");
                    validar = int.TryParse(Console.ReadLine(), out totalGoles);
                } while (!validar);

                do
                {
                    Console.WriteLine("Ingrese Total de Partidos: ");
                    validar = int.TryParse(Console.ReadLine(), out totalPartidos);
                } while (!validar);

                validar = equipo + (new Jugador(dni, nombre, totalGoles, totalPartidos));

            } while (!validar);
            Console.ReadKey();
        }
    }
}
