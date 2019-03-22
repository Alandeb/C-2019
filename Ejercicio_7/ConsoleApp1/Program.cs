using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime actual = new DateTime();
            string anio,mes,dia;
            int anio2, mes2, dia2;
            // Console.Write("Hora: {0:d} " , DateTime.Now);// con d solo aparece el año mes y dia
            Console.Write("Escirba el año: ");
            anio = Console.ReadLine();
            if (!int.TryParse(anio, out anio2))
            {
                Console.Write("Escirba el año: ");
                anio = Console.ReadLine();
                int.TryParse(anio, out anio2);
            }
            Console.Write("Escirba el mes: ");
            mes = Console.ReadLine();
            if (!int.TryParse(mes, out mes2))
            {
                Console.Write("Escirba el mes: ");
                mes = Console.ReadLine();
                int.TryParse(mes, out mes2);
            }
            Console.Write("Escirba el dia: ");
            dia = Console.ReadLine();
            if (!int.TryParse(dia, out dia2))
            {
                Console.Write("Escirba el dia: ");
                dia = Console.ReadLine();
                int.TryParse(dia, out dia2);
            }
            anio2 = DateTime.Now.Year - anio2;
            dia2 = DateTime.Now.Day - dia2;
            mes2 = mes2 - DateTime.Now.Month ;
            
            anio2 = anio2*356;
            dia2 = dia2 + anio2;
            mes2 = (mes2)*31;
            dia2 = dia2 + mes2;
            Console.Write("usted nacio hace: " + dia2 ," DIAS");
            Console.ReadKey();
        }
    }
}
