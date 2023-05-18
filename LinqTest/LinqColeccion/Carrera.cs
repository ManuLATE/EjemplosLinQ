using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class Carrera
    {
        public int idCarrera { get; set; }
        public string nombreCarrera { get; set; }

        public void getDatosCarrera()
        {
            Console.WriteLine("Carrera {0}, con ID {1}", nombreCarrera, idCarrera);
        }
    }
}
