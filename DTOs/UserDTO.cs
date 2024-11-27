using System.ComponentModel.DataAnnotations;

namespace EvSumativa4.DTOs
{
    public class UserDTO
    {
        [EmailAddress]
        public string Correo {get;set;}
        [MaxLength(15)]
        public string Nombre {get;set;}
        [MaxLength(100)]
        public string Apellidos {get;set;}
        [MaxLength(30)]
        public string Contraseña {get;set;}
    }
}