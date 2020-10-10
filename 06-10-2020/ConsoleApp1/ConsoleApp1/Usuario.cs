using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{                   
    //[Table ("Usuario")]
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }





        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // public int UsuarioPK { get; set; }

        // [MaxLength(50)]
        // [MinLength (10)]
        // public string Nombre { get; set; }

        // [Required]
        //// [Column("password",TypeName ="char(20)")]
        // public string Clave { get; set; }

        // //propiedad dentro del modelo que no quiero que se genere en la bd ni que la vaya a buscar
        // //esta prop no es un campo de la tabla
        // [NotMapped]
        // public string Imagne { get; set; }

    }
}
