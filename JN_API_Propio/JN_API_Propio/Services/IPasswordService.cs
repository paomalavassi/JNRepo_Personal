using System.Security.Cryptography;
using System.Text;

namespace JN_API_Propio.Services
{
    public interface IPasswordService
    {
        string Cifrar(string userId, TimeSpan vigencia);
        string Descifrar(string token);
    }
}
