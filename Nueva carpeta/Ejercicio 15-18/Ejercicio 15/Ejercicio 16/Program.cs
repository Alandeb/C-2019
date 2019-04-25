using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nota1 = 0,
                 nota2 = 0;
            string nombre,
                   apellido,
                   convertir;
            int legajo = 0;
            bool validar = false;

            Alumno[] alumnos = new Alumno[3];

            // Cargo datos
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nota 1 y nota 2: ");
                do
                {
                    convertir = Console.ReadLine();
                    validar = byte.TryParse(convertir, out nota1);
                } while (validar == false);
                do
                {
                    convertir = Console.ReadLine();
                    validar = byte.TryParse(convertir, out nota2);
                } while (validar == false);
                Console.WriteLine("Ingrese nro legajo: ");
                do
                {
                    convertir = Console.ReadLine();
                    validar = int.TryParse(convertir, out legajo);
                } while (validar == false);

                alumnos[i] = new Alumno(nombre, apellido, legajo);
                alumnos[i].Estudiar(nota1, nota2);
                alumnos[i].CalcularFinal();
                Console.WriteLine(alumnos[i].Mostrar());
            }
        }
    }
}
