using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Equipo
    {
        private static List<Jugador> jugadores ;
        private string nombre;
        private short cantidadDeJugadores;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo (short cantidad ,string nombre)
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e,Jugador j)
        {

        }
    }
}
