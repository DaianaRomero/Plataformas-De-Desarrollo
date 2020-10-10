using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Usuarios
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsuarioPK { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        public string Nombre { get; set; }
        public string Clave { get; set; }

        //[NotMapped]
        //public string Imagen { get; set; }


    }
}
