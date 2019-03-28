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
        public Alumno (byte nota1 , byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }


    }
    
    public class Prueba
    {
        Alumno prueba = new Alumno();
        Alumno prueba2 = new Alumno()
            
    }

}
