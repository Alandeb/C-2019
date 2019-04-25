using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        #region ATRIBUTOS

        private int dni;
        private string nombre;
        private int partidosJugados;
        private static float promedioGoles;
        private int totalesGoles;

        #endregion

        #region CONSTRUCTORES

        private Jugador()
        {
            promedioGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            :this(dni, nombre)
        {
            this.totalesGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region METODOS

        public float GetPromedioGoles()
        {
            return (promedioGoles);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Jugador: " + this.nombre);
            sb.Append("DNI: " + this.dni);
            sb.Append("Partidos Jugados: " + this.partidosJugados);
            sb.Append("Promedio de Goles: " + GetPromedioGoles());
            sb.Append("Total de Goles: " + this.totalesGoles);

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1 == j2);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        #endregion
    }
}
