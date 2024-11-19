using System.Security.Cryptography;
using System.Text;

namespace Lab8.Services.Implementations;

internal class PasswordEncryptionService : IPasswordEncryptionService
{
    public string EncryptPassword(string password)
    {
        return Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
    }
}
