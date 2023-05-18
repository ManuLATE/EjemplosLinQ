using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class Alumno
    {
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public string matricula { get; set; }
        public double promedio { get; set; }
        public int idCarrera { get; set; }
        public string nombreCarrera { get; set; }

        public void getDatosAlumno()
        {
            Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera {3}", nombre, matricula, promedio, nombreCarrera);
        }
    }
}
