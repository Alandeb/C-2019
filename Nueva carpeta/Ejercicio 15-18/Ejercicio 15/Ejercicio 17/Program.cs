using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string pintar,
                   convertir,
                   salir = "s";
            int gasto = 0;
            bool validar = false;
            
            // Creo el objeto
            Boligrafo[] boligrafos = new Boligrafo[2];

            // Creo los 2 boligrafos
            boligrafos[0] = new Boligrafo(100, ConsoleColor.Blue);
            boligrafos[1] = new Boligrafo(50, ConsoleColor.Red);
            do
            {

                if ((int)boligrafos[0].GetTinta() < 1 && (int)boligrafos[1].GetTinta() < 1) {
                    boligrafos[0].Recargar();
                    boligrafos[1].Recargar();
                }
                    
                do
                {
                    Console.WriteLine("Ingrese cuanto pintar: ");
                    convertir = Console.ReadLine();
                    validar = int.TryParse(convertir, out gasto);
                } while (validar == false);
                
                // Tinta actual
                Console.WriteLine("TINTA ACTUAL: \n" +
                                  "------------ \n\n");
                Console.WriteLine("{0}", boligrafos[0].GetTinta());

                // Pintar
                boligrafos[0].Pintar(gasto, out pintar);
                Console.BackgroundColor = boligrafos[0].GetColor();
                Console.WriteLine("Color Azul: \n {0}", pintar);
                Console.BackgroundColor = boligrafos[1].GetColor();
                boligrafos[1].Pintar(gasto, out pintar);
                Console.WriteLine("Color Rojo: \n {0}", pintar);
                Console.ResetColor();

                // Resto de tinta
                Console.WriteLine("RESTO DE TINTA:\n" +
                                  "---------------\n");
                Console.WriteLine("{0}", boligrafos[0].GetTinta());

                // Volver a usar
                Console.WriteLine("Desea salir? (s/n)");
                salir = Console.ReadLine();
            } while (!salir.Equals("s"));
            


        }
    }
}
