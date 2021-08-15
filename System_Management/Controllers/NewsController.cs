using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System_Management.Models;
using System.Web.SessionState;
using System_Management.Util.Filter;

namespace System_Management.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
    [CustomAuthenticationFilter]
    public class NewsController : Controller
    {
        private readonly SystemManagementEntities _db = new SystemManagementEntities();
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Notification()
        {
            var news = (from n in _db.News where n.IsImportant == true select n).ToList();

            if (news != null && news.Count > 0)
            {
                List<News> listNews = (List<News>)news;
                ViewBag.News = listNews;
                ViewBag.Message = "Thông báo";

                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}