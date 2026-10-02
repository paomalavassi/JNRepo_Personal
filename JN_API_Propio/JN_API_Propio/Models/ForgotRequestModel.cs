using System.ComponentModel.DataAnnotations;

namespace JN_API_Propio.Models
{
    public class ForgotRequestModel
    {
        [Required]
        public string CorreoElectronico { get; set; } = string.Empty;

    }
}
