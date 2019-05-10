using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;
        public Figura(string desc, int sto, double pr, double altura) : base(desc, sto, pr)
        {
            this.altura = altura;
        }
        public Figura(int sto, double pr, double altura) : this(("Figura "+altura+" cm"),sto, pr,altura)
        {  
        }
        /// <summary>
        /// Cadena de caracteres con toda la descripcion
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder(base.ToString());
            cadena.AppendFormat("\nAutor: {0}" , altura);
            return cadena.ToString();
        }
    }
}
