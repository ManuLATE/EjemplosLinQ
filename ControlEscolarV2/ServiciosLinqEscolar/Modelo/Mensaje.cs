using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosLinqEscolar.Modelo
{
    public class Mensaje
    {
        public Boolean error { set; get; }
        public string mensaje { set; get; } 
        public usuario usuarioLogin { set; get; }

    }
}