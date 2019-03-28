using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public static class ValidaS_N
    {
        public static bool ValidarRespuesta(char c)
        {
            bool r = false;
            if (c == 's' || c == 'S')
            {
                r = true;
            }
            return r;
        }
    }
}
