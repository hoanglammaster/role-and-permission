using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Management.Util
{
    public interface IEncrypter
    {
        string Encrypt(string password);
        string Encrypt(string password, byte[] salt, int cost);
    }
}
