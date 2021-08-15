using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace System_Management.Util
{
    public class Encrypter : Size, IEncrypter
    {
        private readonly int _cost;
        public Encrypter()
        {
            _cost = random.Next(MIN_COST, MAX_COST);
        }
        public Encrypter(int cost)
        {
            _cost = cost;
        }

        public string Encrypt(string password)
        {
            int iterator = 1 << _cost;
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT];
            provider.GetBytes(salt);
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterator);
            byte[] hash = pbkdf2.GetBytes(HASH);
            byte[] result = new byte[HASH+SALT];
            hash.CopyTo(result, 0);
            salt.CopyTo(result, HASH);
            return _cost+Convert.ToBase64String(result);

        }
        public string Encrypt(string password,byte[] salt, int cost)
        {
            int iterator = 1 << cost;
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterator);
            byte[] hash = pbkdf2.GetBytes(HASH);
            byte[] result = new byte[HASH + SALT];
            hash.CopyTo(result, 0);
            salt.CopyTo(result, HASH);
            return cost + Convert.ToBase64String(result);

        }
    }
}