using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Refolio.Helper;

public static class PasswordHandler
{
    public static Tuple<string, string> HashPassword(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(128/8);

        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 10000,
            numBytesRequested: 256 / 8
        ));
        
        return new Tuple<string, string>(hashed, Convert.ToBase64String(salt));
    }

    public static bool VerifyPassword(string input, string hashed, string salt)
    {
        Tuple<string, string> hashInput = HashPassword(input);
        if(hashed != hashInput.Item1) return false;
        
        return true;
    }
}