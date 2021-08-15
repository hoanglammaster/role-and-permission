using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System_Management.Models;

namespace System_Management.Util.Filter
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly int[] allowedroles;
        public CustomAuthorizeAttribute(params int[] roles)
        {
            this.allowedroles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            var user = httpContext.Session["id"];
            if (user != null)
                using (var context = new SystemManagementEntities())
                {
                    var userId = Convert.ToInt32(user);
                    var userRole = (from u in context.UserToRoles
                                    where u.UserId == userId
                                    select u.RoleId
                                    ).FirstOrDefault();
                    foreach (var role in allowedroles)
                    {
                        if (role == Convert.ToInt32(userRole)) return true;
                    }
                }


            return authorize;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
               new RouteValueDictionary
               {
                    { "controller", "Home" },
                    { "action", "Index" }
               });
        }
    }
}