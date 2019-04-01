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
            Boligrafo boligrafo1 = new Boligrafo(100 , ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;
            if(boligrafo1.Pintar(10, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.Write(dibujo);
            }

            if (boligrafo2.Pintar(20, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.Write(dibujo);
            }
            Console.ReadKey();



            
        }
    }
}
