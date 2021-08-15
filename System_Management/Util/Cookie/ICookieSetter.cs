using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace System_Management.Util
{
    public interface ICookieSetter
    {
        void SetCookie(string key, string value, int expire, Controller controller);
    }
}
