using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academia.Entidades
{
    public class Persona
    {
        internal string materia;
        internal string seccion;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string TipoPersona { get; set; } 
    }
}
