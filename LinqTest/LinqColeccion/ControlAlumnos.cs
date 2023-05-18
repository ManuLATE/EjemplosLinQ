using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add(new Carrera { idCarrera = 1, nombreCarrera = "Ingenieria de Software"});
            carreras.Add(new Carrera { idCarrera = 2, nombreCarrera = "Redes y Servicios de computo" });

            alumnos.Add(new Alumno 
            { idAlumno = 1, 
              nombre = "Xcaret Sorrosa Mercado", 
              matricula = "S18018409",
              promedio = 9.41,
              idCarrera = 1,
              nombreCarrera = "Ingenieria de software" 
            });

            alumnos.Add(new Alumno
            {
                idAlumno = 2,
                nombre = "Manuel Ladron de Guevara",
                matricula = "S19030174",
                promedio = 8.15,
                idCarrera = 1,
                nombreCarrera = "Ingenieria de software"
            });

            alumnos.Add(new Alumno
            {
                idAlumno = 3,
                nombre = "Diana Pilar Miranda",
                matricula = "S19030189",
                promedio = 8.94,
                idCarrera = 2,
                nombreCarrera = "Redes y Servicios de Computo"
            });
        }

        public void obtenerAlumnosPorCarrera(int idCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos join carrera in carreras on alumno.idCarrera equals carrera.idCarrera where alumno.idCarrera == idCarrera select alumno;

            foreach (Alumno alumno in resultado)
            {
                alumno.getDatosAlumno();
            }
        }
    }
}
