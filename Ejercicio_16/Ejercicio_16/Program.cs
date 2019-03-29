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
            Alumno student1 = new Alumno(1146 , "alan" , "debonis");
            Alumno student2 = new Alumno(1045 , "hernan" , "pato");
            Alumno student3 = new Alumno(1080, "juan" , "domingo");
            string parseint;
            int  flagnota1 = 0, flagnota2 = 0, numero ;
            byte nota1 = 0 ,nota2 = 0 ;
            
                do
                {
                    Console.Write("Ingrese un nota1: ");
                    parseint = Console.ReadLine();
                    if ((int.TryParse(parseint, out numero)) && numero >= 0 && numero <= 10)
                    {
                        flagnota1 = 1;
                        nota1 = (byte)numero;

                        do
                        {
                            Console.Write("Ingrese un nota2: ");
                            parseint = Console.ReadLine();
                            if ((int.TryParse(parseint, out numero)) && numero >= 0 && numero <= 10)
                            {
                                flagnota2 = 1;
                                nota2 = (byte)numero;
                        }
                            else
                            {
                                Console.WriteLine("ERROR !!");
                            }
                        } while (flagnota2 == 0);
                    }
                    else
                    {
                        Console.WriteLine("ERROR !!");
                    }

                } while (flagnota1 == 0 && flagnota2 == 0);
            student1.Estudiar(nota1, nota2);

            nota1 = 0;
            nota2 = 0;
            flagnota1 = 0;
            flagnota2 = 0;
            do
            {
                Console.Write("Ingrese un nota1: ");
                parseint = Console.ReadLine();
                if ((int.TryParse(parseint, out numero)) && numero >= 0 && numero <= 10)
                {
                    flagnota1 = 1;
                    nota1 = (byte)numero;

                    do
                    {
                        Console.Write("Ingrese un nota2: ");
                        parseint = Console.ReadLine();
                        if ((int.TryParse(parseint, out numero)) && numero >= 0 && numero <= 10)
                        {
                            flagnota2 = 1;
                            nota2 = (byte)numero;
                        }
                        else
                        {
                            Console.WriteLine("ERROR !!");
                        }
                    } while (flagnota2 == 0);
                }
                else
                {
                    Console.WriteLine("ERROR !!");
                }

            } while (flagnota1 == 0 && flagnota2 == 0);

            student2.Estudiar(nota1, nota2);
            nota1 = 0;
            nota2 = 0;
            flagnota1 = 0;
            flagnota2 = 0;
            do
            {
                Console.Write("Ingrese un nota1: ");
                parseint = Console.ReadLine();
                if ((int.TryParse(parseint, out numero)) && numero >= 0 && numero <= 10)
                {
                    flagnota1 = 1;
                    nota1 = (byte)numero;

                    do
                    {
                        Console.Write("Ingrese un nota2: ");
                        parseint = Console.ReadLine();
                        if ((int.TryParse(parseint, out numero)) && numero >= 0 && numero <= 10)
                        {
                            flagnota2 = 1;
                            nota2 = (byte)numero;
                        }
                        else
                        {
                            Console.WriteLine("ERROR !!");
                        }
                    } while (flagnota2 == 0);
                }
                else
                {
                    Console.WriteLine("ERROR !!");
                }

            } while (flagnota1 == 0 && flagnota2 == 0);

            student3.Estudiar(nota1, nota2);

            student1.CalcularFinal();
            student2.CalcularFinal();
            student3.CalcularFinal();
            Console.WriteLine(student1.Mostrar());
            Console.WriteLine(student2.Mostrar());
            Console.WriteLine(student3.Mostrar());
            Console.ReadKey();
        }
            
    }
}
