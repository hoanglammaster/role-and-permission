using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Management.Util
{
    public interface IAuthentication
    {
        bool Authentic(string password, string token);
    }
}
