using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        // Atributos
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        
        //Constructores
        public Alumno()
        {

        }

        public Alumno(string nombre, string apellido, int legajo)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        // Metodos
        public void CalcularFinal()
        {
            float promedio = 0;
            if (this.nota1>3 && this.nota2 >3)
            {
                promedio = this.nota1 + this.nota2;
                promedio = promedio / 2;
                this.notaFinal = promedio;
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.Append("Alumno: " + this.nombre + this.apellido);
            mostrar.Append("\nLegajo: " + this.legajo);
            mostrar.Append("\nNota 1 : " + this.nota1);
            mostrar.Append("\nNota 2 : " + this.nota2);
            if (this.notaFinal != -1)
                mostrar.Append("\nNota final: " + this.notaFinal);
            else
                mostrar.Append("\nNota final: DESAPROBADO");
            return mostrar.ToString();
        }
    }
}
