using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Management.Util
{
    public class Authenticator : Size, IAuthentication
    {
        private readonly IEncrypter _encrypter;
        public Authenticator(IEncrypter encrypter)
        {
            _encrypter = encrypter;
        }

        public bool Authentic(string password, string token)
        {
            try
            {
                int _cost = Convert.ToInt32(token.Substring(0, 2));
                byte[] passwordHashed = Convert.FromBase64String(token.Substring(2, token.Length - 2));
                byte[] salt = new byte[SALT];
                Buffer.BlockCopy(passwordHashed, HASH, salt, 0, SALT);
                string result = _encrypter.Encrypt(password, salt, _cost);
                return result.Equals(token);
            }
            catch (FormatException e)
            {
                return false;

            }
            catch (NullReferenceException e)
            {
                return false;
            }
        }
    }
}
