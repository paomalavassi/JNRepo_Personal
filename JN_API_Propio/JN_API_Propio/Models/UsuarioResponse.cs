namespace JN_API_Propio.Models
{
    public class UsuarioResponse : ResponseApi
    {
        public int IdUsuario { get; set; }
        public String NombreCompleto { get; set; } = string.Empty;
        public string Identificacion { get; set; } = string.Empty;
        public string CorreoElectronico { get; set; } = string.Empty;
        public bool Estado { get; set; }
        public short IdRol { get; set; }
        public string NombreRol { get; set; } = string.Empty;
    }
}
