using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entidades
{                   
   
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }


        public Usuario() { }   //constructor implicito 

        public Usuario(int Id, string Nombre, string Clave)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Clave = Clave;
            
        }

    }
}
