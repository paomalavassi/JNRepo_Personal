namespace JN_Web_Propio.Models
{

        public class RegisterRequestModel
    {
        public string Identificacion { get; set; } = string.Empty;

        public string NombreCompleto { get; set; } = string.Empty;

        public string CorreoElectronico { get; set; } = string.Empty;

        public string Contrasenna { get; set; } = string.Empty;
    }
    }