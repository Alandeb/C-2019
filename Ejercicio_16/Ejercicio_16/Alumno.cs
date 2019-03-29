using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        public Alumno()
        {
            nota1 = 0;
            nota2 = 0;
            notaFinal = 0;
            legajo = 0;
            apellido = " ";
            nombre = " ";
        }
        public Alumno (byte nota1 , byte nota2)//constructor
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
        public Alumno (int leg, string nom ,string ape)// constructor del punto A
        {
            this.legajo = leg;
            this.nombre = nom;
            this.apellido = ape;
        }
                    
        public void Estudiar (byte nota1 , byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            
        }
        public void CalcularFinal()
        {
            if (nota1 >= 4 && nota2 >= 4)
            {
                Random objram = new Random();
                this.notaFinal=objram.Next(4, 10);

            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public string Mostrar()
        {
            if (notaFinal == -1)
            {
                return string.Format("Nota 1: {0}, Nota 2: {1}, Nota final: Desaprobado, " +
                    "Legajo: {2}, Nombre: {3}, Apellido: {4} ", nota1,nota2,legajo,nombre,apellido);
            }
            else
            {
                return string.Format("Nota 1: {0}, Nota 2: {1}, Nota final: {2}, " +
                    "Legajo: {3}, Nombre: {4}, Apellido: {5}", nota1, nota2,notaFinal, legajo, nombre, apellido);
            }
        }
    }

}
