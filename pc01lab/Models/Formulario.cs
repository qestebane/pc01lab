using System;
using System.ComponentModel.DataAnnotations;

namespace pc01lab.Models
{
    
    public class Formulario
    {
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Display(Name="Apellido")]
        public String LastName { get; set; }

        [Display(Name="Distrito")]
        public String district { get; set; }

        [Display(Name="Banco")]
        public String bank { get; set; }

        [Display(Name="Edad")]
        public String old { get; set; }

        [Display(Name="Sexo")]
        public String sex { get; set; }

        public String Response { get; set; }

    }
}