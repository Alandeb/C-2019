using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro = 0,
                suma = 0,
                flag = 0;
            string convert;
            char continuar = 'n';
            bool validar = false;

            Console.WriteLine("SUMA DE ENTEROS: \n" +
                              "---------------\n");
            do {

                for (int i = 0; i < 2; i++)
                {
                    do
                    {
                        if (flag == 0)
                            Console.WriteLine("Ingrese un numero: ");
                        else
                            Console.WriteLine("ERROR!, ingrese un nro valido: ");
                        convert = Console.ReadLine();
                        validar = int.TryParse(convert, out nro);
                        flag = 1;
                    } while (validar == false);
                    flag = 0;
                    suma = suma + nro;
                }
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("\n¿Continuar? (S/N)");
                convert = Console.ReadLine();
                Char.TryParse(convert, out continuar);
                //validar = ValidarRespuesta.ValidaS_N(continuar);
            } while (ValidarRespuesta.ValidaS_N(continuar));

                
            
        }
    }
}
