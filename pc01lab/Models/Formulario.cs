using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc01lab.Models
{
    [Table("t_bono")]

    public class Formulario
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
        [Column("name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("lastname")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Distrito")]
        [Display(Name="Distrito")]
        [Column("district")]
        public String district { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Banco")]
        [Display(Name="Banco")]
        [Column("bank")]
        public String bank { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Edad")]
        [Display(Name="Edad")]
        [Column("old")]
        public int old { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Edad")]
        [Display(Name="Sexo")]
        [Column("gender")]
        public String sex { get; set; }
        
        
        [Column("author")]

        private String author { get; }

        [NotMapped]

        public String Response { get; set; }

    }
}