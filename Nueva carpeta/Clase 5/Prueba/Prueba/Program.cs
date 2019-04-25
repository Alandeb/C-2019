using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[0];
            
   

            Console.WriteLine(array.Length);
            
            
            if (Object.ReferenceEquals(array, null)){

                array[0] = "BUENOS DIAS";
                foreach (string a in array)
                {
                    if (a == null)
                        Console.WriteLine("ES NULL");
                    else
                        Console.WriteLine(a);
                }
            }

            Console.WriteLine("No entro al if");
            Console.ReadKey();
        }
    }
}
