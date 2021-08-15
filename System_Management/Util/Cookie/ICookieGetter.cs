using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace System_Management.Util
{
    public interface ICookieGetter
    {
        string GetCookie(string key, Controller controller);
    }
}
