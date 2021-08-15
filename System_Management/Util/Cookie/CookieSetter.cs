using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System_Management.Util.Cookie
{
    public class CookieSetter : ICookieSetter
    {
        public void SetCookie(string key, string value, int expire, Controller controller)
        {
            HttpResponseBase httpResponse = controller.Response;
          
            HttpCookie cookie = new HttpCookie(key, value);
            cookie.Expires = DateTime.Now.AddDays(expire);
            httpResponse.Cookies.Add(cookie);
        }
    }
}