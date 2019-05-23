using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Entidades
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description ="Codigo")]     
        public int Id { get; set; }

        [Display(Description = "Nombre de usuario")]  
        public string NombreUsuario { get; set; }

        [Display(Description = "Edad")]
        public int Edad { get; set; }

        [Display(Description = "Tipo de usuario")]
        public int Tipo { get; set; }
    }
}
