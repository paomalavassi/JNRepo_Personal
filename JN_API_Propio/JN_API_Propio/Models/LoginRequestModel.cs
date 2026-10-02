using System.ComponentModel.DataAnnotations;

namespace JN_API_Propio.Models
{
    public class LoginRequestModel
    {
        [Required]
        public string CorreoElectronico { get; set; } = string.Empty;

        [Required]
        public string Contrasenna { get; set; } = string.Empty;
    }
}
