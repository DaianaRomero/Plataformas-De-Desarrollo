using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Data
{

    public class Recurso
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
       // public int TipoIdUsuario { get; set; }
        //public Usuario Usuario { get; set; }


        public Recurso() { }   //constructor implicito 

        public Recurso(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            
        }
    }
}
