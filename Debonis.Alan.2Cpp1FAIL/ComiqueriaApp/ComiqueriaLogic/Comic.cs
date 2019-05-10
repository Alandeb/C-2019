using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        public enum TipoComic
        {
            Occidental,
            Oriental
        }

        private string autor;
        TipoComic tipoComic;

        public Comic(string desc , int sto , double pr , string autor , TipoComic tipoComic) : base (desc , sto , pr)
        {
            this.tipoComic = tipoComic;
            this.autor = autor;
        }
        /// <summary>
        /// Cadena de caracteres con toda la descripcion
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder(base.ToString());
            cadena.AppendFormat("\nAutor: {0} \nTipoComic: {1}", autor, tipoComic);
            return cadena.ToString() ;
        }
    }
}
