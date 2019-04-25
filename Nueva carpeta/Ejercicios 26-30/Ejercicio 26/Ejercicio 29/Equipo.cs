using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Equipo
    {
        #region ATRIBUTOS

        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region CONSTRUCTOR

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        #endregion

        #region METODOS

        public static bool operator +(Equipo e, Jugador j)
        {
            int flag = 0;
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                {
                    flag = 1;
                    break;
                }
            }

            if(flag == 0 && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
