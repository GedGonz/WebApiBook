using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibros.Modelo
{
    public class Libro
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Portada { get; set; }
        public DateTime Fecha { get; set; }
        public Autor Autor { get; set; }
    }
}
