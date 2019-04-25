using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        // Constante
        const short cantidadTintaMaxima = 100;

        // Atributos
        private ConsoleColor color;
        private short tinta;

        // Constructor
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        // Metodos

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta >= 0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = (short)((int)this.tinta + (int)tinta);
            }
            else
            {
                this.tinta = (short)((int)this.tinta + (int)tinta);
            }
                
            
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
            
        }

        public bool Pintar(int gasto, out string dibujo)
        {

            dibujo = "*";
            if (gasto > 0)
            {

                SetTinta((short)-gasto);
                for (int i = 0; i < (int)gasto; i++)
                {
                    dibujo += "*";
                    if (dibujo.Length == gasto)
                        break;
                }
                return true;
            }
            
            return true;   

        }
        
        

    }
}
