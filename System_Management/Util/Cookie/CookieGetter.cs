using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System_Management.Util.Cookie
{
    public class CookieGetter : ICookieGetter
    {
        public string GetCookie(string key, Controller controller)
        {
            HttpRequestBase httpRequest = controller.Request;
            HttpCookie cookie = httpRequest.Cookies[key];
            if (cookie != null)
            {
                return cookie.Value;
            }
            else
            {
                return "";
            }
        }
    }
}