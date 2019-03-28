using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validar
    {
        public static bool Validacion(int valor, int min, int max)
        {
            bool retorno = true;
            if (valor > max || valor < min)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
