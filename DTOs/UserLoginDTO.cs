using System.ComponentModel.DataAnnotations;

namespace EvSumativa4.DTOs
{
    public class UserLoginDTO
    {
        [EmailAddress]
        public string Correo {get;set;}
        [MaxLength(30)]
        public string Contraseña {get;set;}
    }
}