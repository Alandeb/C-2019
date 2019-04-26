using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                    directorTecnico = value;
            }
        }
        /// <summary>
        /// Muestra una cadena con todos los datos el equipo
        /// </summary>
        /// <param name="e">paramatro del equipo a mostrar</param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder cadena = new StringBuilder();
            if (e.directorTecnico == null)
            {
                cadena.AppendLine("Director Tecnico: " + "Sin DT asignado");
            }
            else
            {
                cadena.AppendLine("Director Tecnico: " + e.directorTecnico);
            }
            foreach(Jugador j in e.jugadores)
            {
                cadena.AppendLine(j.Mostrar());
            }
            return cadena.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j))
                return true;
            return false;
        }

        public static bool operator !=(Equipo e , Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e , Jugador j)
        {
            if (e != j)
            {
                if(e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
                {
                    e.jugadores.Add(j);
                }
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool r = false;
            int contArquero = 0, contDefensor = 0, contCentro = 0, contDelantero = 0;
            if(e.directorTecnico != null && e.jugadores.Count == cantidadMaximaJugadores)
            {
               foreach(Jugador j in e.jugadores)
                {
                    if (j.Posicion == Posicion.Arquero)
                        contArquero++;
                    if (j.Posicion == Posicion.Defensor)
                        contDefensor++;
                    if (j.Posicion == Posicion.Central)
                        contCentro++;
                    if (j.Posicion == Posicion.Delantero)
                        contDelantero++;
                }
                if (contArquero == 1 && contCentro >= 1 && contDefensor >= 1 && contDelantero >= 1)
                    r = true;
            }
            return r;
        }
    }
}
