using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System_Management.Models;
using System_Management.Util;
using System.Web.SessionState;
using System_Management.Util.Cookie;
using System.Data.Entity.Core.Objects;
using System_Management.Util.Filter;

namespace System_Management.Controllers
{
    [SessionState(SessionStateBehavior.Default)]
    public class DefaultsController : Controller
    {
        private readonly SystemManagementEntities  db = new SystemManagementEntities();

        // GET: Defaults
        public ActionResult Index(string message)
        {
            ICookieGetter cookieGetter = new CookieGetter();
            string account = cookieGetter.GetCookie("account", this);
            ViewBag.Account = account;
            
            var schools = db.Schools.Include(s => s.Contact);
            List<School> listSchool = schools.ToList();
            ViewBag.School = listSchool;
            ViewBag.Message = message;
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult UserLogIn(string username, string password, string selectedCampus)
        {
            if(Convert.ToInt32(selectedCampus) == -1)
            {
                return RedirectToAction("Index",new { message = "Select your campus"});
            }
            else
            {
                ObjectResult<string> result = db.sp_UserLogin(username, int.Parse(selectedCampus));
                string token = result.FirstOrDefault();

                IAuthentication authencator = new Authenticator(new Encrypter());
                bool isSusscess = authencator.Authentic(password, token);
                if (isSusscess)
                {
                    var user = (from u in db.Users where u.UserName == username select u).Single();
                    Session["account"] = user.UserName;
                    Session["id"] = user.UserId;
                    Session["campus"] = (from u in db.Users join su in db.SchoolHasUsers on u.UserId equals su.UserId join s in db.Schools on su.SchoolId equals s.SchoolId select s.SchoolName).First();
                    ICookieSetter cookieSetter = new CookieSetter();
                    cookieSetter.SetCookie("account", username, 7, this);

                    return RedirectToAction("Notification", "News");
                }
                else
                {
                    return RedirectToAction("Index", new { message = "Your account can't login!"});
                }
            }

            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
