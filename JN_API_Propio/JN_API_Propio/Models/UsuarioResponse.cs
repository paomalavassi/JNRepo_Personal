namespace JN_API_Propio.Models
{
    public class UsuarioResponse : ResponseApi
    {
        public int IdUsuario { get; set; }
        public String NombreCompleto { get; set; } = string.Empty;
        
    }
}
