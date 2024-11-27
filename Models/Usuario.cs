using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EvSumativa4.Models
{
    public class Usuario
    {
        [Key]
        public Guid Id {get;set;}
        [EmailAddress]
        [Required]
        [MaxLength(100)]
        public string Correo {get;set;}
        [Required]
        [MaxLength(15)]
        public string Nombre {get;set;}
        [Required]
        [MaxLength(100)]
        public string Apellidos {get;set;}
        [Required]
        public string Contraseña {get;set;}
        public bool EstaEliminado {get;set;} = false;
    }
}