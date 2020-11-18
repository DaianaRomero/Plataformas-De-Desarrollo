using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Data
{
    public class Detalle
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public String Tiempo { get; set; }
         public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }


        public Detalle() { }   //constructor implicito 

        public Detalle(int Id, DateTime Fecha, String Tiempo)
        {
            this.Id = Id;
            this.Fecha = Fecha;
            this.Tiempo = Tiempo;

        }
    }
}
