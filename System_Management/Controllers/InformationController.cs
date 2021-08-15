using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using System_Management.Models;
using System_Management.Util.Filter;

namespace System_Management.Controllers
{
    [SessionState (SessionStateBehavior.Required)]
    [CustomAuthenticationFilter]
    public class InformationController : Controller
    {
        private readonly SystemManagementEntities _db = new SystemManagementEntities();
        // GET: Information
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SubjectFee()
        {
            var id = Session["id"];
            if (id == null)
            {
                return RedirectToAction("Index", "Defaults");
            }
            else
            {
                List<Subject> subjects = _db.Subjects.ToList();
                ViewBag.Subjects = subjects;
                ViewBag.Message = "Subject Fees";
                return View();
            }
            
        }
    }
}