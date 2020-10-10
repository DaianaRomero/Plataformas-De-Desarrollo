using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Detalle
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Tiempo { get; set; }
        public int TipoIdRecurso { get; set; }
        public Recurso Recurso { get; set; }
        public int TipoIdTarea { get; set; }
        public Tarea Tarea { get; set; }
    }
}
