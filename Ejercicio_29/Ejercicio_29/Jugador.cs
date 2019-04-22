using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        private  int dni;
        private  int partidosJugados;
        private  int totalGoles;
        private  string nombre;
        private  static float promedioGoles;

        private Jugador()
        {
            partidosJugados = 0;
            totalGoles = 0;
            promedioGoles = 0;
        }

        public Jugador(int dni,string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;

        }
        public  Jugador(int dni, string nombre,int totalGoles,int totalPartidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;
        }
        public float GetPromedioGoles()
        {
            if (partidosJugados>0 && totalGoles>0)
                promedioGoles = totalGoles / partidosJugados;
            return promedioGoles;
        }
        public string MostrarDatos()
        {
            return string.Format("Jugador: {0} , DNI: {1} ,Partidos Jugados: {2},Goles Totales: {3} , Promedio de Goles {4}", nombre, dni, partidosJugados, totalGoles, promedioGoles);
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.dni == j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
