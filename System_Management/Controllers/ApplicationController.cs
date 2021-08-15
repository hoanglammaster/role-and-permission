using NPOI.OpenXml4Net.OPC;
using System;
using System.Collections.Generic;
using System.IO;
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
    public class ApplicationController : Controller
    {
        private readonly SystemManagementEntities _db = new SystemManagementEntities();
        // GET: Application
        [CustomAuthorize(1,2)]
        public ActionResult Index()
        {
            return View();
        }
        [CustomAuthorize(3,4)]  
        [HttpPost]

        public ActionResult SendApplication(string type, string purpose, HttpPostedFileBase file)
        {
            int typeApp = Convert.ToInt32(type);
            var id = (int)Session["id"];

            if (file!=null && file.ContentLength > 0)
            {
                var fileName = file.FileName;
                using (var memoryStream = new MemoryStream())
                {
                    file.InputStream.CopyTo(memoryStream);
                    var fileByte = memoryStream.ToArray();
                    _db.SendApp(typeApp, id, purpose, fileName, fileByte);
                }
            }
            else
            {
                _db.SendApp(typeApp, id, purpose, null, null);
            }
            _db.SaveChanges();
            return RedirectToAction("Normal");
        }
        [CustomAuthorize(3,4)]
        public ActionResult Normal(string Types)
        {
            int selectedType;
            Int32.TryParse(Types, out selectedType);
            var types = _db.ApplicationTypes.ToList();
            int userId = Convert.ToInt32(Session["id"]);
            var balence = (from u in _db.UserInformations where u.UserId == userId select u.Balance).FirstOrDefault();
            ViewBag.Balence = balence;
            if (selectedType != 0)
            {

                ViewBag.Selected = selectedType;
                ViewBag.Cost = types.Find(e => e.Id == selectedType).Cost;
            }
            else
            {
                ViewBag.Selected = 0;
                ViewBag.Cost = 0;
            }

            List<SelectListItem> listTypes = new List<SelectListItem>();
            listTypes.Add(new SelectListItem() { Text = "Choose Application Type(Chọn loại đơn)", Value = "0" });
            foreach(var type in types)
            {
                listTypes.Add(new SelectListItem() { Text = type.TypeName, Value = type.Id.ToString() });
            }
            
            ViewBag.Types = listTypes;
            ViewBag.Message = "Gửi đơn";
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}