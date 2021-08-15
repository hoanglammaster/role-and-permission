using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using System_Management.Models;
using System_Management.Util.Filter;

namespace System_Management.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
    [CustomAuthenticationFilter]
    public class HomeController : Controller
    {
        private readonly SystemManagementEntities _db = new SystemManagementEntities();

        [Obsolete]
        public ActionResult Index(string searchNews)
        {
            if (string.IsNullOrEmpty(searchNews))
            {


                var news = (from n in _db.News where EntityFunctions.DiffMonths(n.CreatedDate, DateTime.Now) < 12 select n).ToList();
                List<News> listNews = (List<News>)news;
                ViewBag.News = listNews;
            }
            else
            {
                var news = _db.SearchNewsByTitle(searchNews);
                List<News> listNews = news.ToList();
                ViewBag.News = listNews;
            }
                return View();
        }
        

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index", "Defaults");
        }
    }
}