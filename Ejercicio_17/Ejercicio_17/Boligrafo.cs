using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        public Boligrafo (short tinta , ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {

            if (tinta <= 100 || tinta >= 0)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar (int gasto,out string dibujo)
        {
            int gas = gasto;
            dibujo = "*";
            do
            {
                tinta = GetTinta();
                if (tinta == 0)
                {
                    
                    for (int i = 0; i < gas-gasto; i++)
                    {
                        dibujo = dibujo + "*";   
                    } 
                    return false;
                }
                else
                {
                    if (gasto != 0)
                    {
                        gasto--;
                        SetTinta(tinta--);
                        
                        
                    }
                }
            } while (gasto != 0);
            for (int i = 0; i < gas - gasto; i++)
            {
                dibujo = dibujo + "*";
            }
            return true;
            
        }

    }
}
