using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Estimacion { get; set; }
        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }
        public bool Estado { get; set; }


        public Tarea() { }   //constructor implicito 

        public Tarea(int Id, string Titulo, DateTime Vencimiento, string Estimacion, bool Estado)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;

            this.Estado = Estado;
        }

    }
}
