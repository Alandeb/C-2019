using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            string validar = c.ToString().ToUpper();
            return (validar.Equals("S"));
        }
    }
}
