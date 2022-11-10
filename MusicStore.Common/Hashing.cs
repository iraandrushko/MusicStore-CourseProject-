using System;
using System.Security.Cryptography;
using System.Text;

namespace MusicStore.Common
{
    public class Hashing
    {
        public static string GetHashString(string password, Guid salt)
        {
            using (var alg = SHA512.Create())
            {
                var hashedInputBytes = alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt.ToString()));

                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                {
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                }
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
