using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Studenter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region student
            routes.Add("List", "Student", "student/list", "_studentlist");
            routes.Add("Create", "Student", "student/create", "_studentcreate");
            routes.Add("Update", "Student", "student/update", "_studentupdate");
            routes.Add("Delete", "Student", "student/delete", "_studentdelete");
            #endregion
            #region teacher
            routes.Add("List", "Teacher", "teacher/list", "_teacherlist");
            routes.Add("Create", "Teacher", "teacher/create", "_teachercreate");
            routes.Add("Update", "Teacher", "teacher/update", "_teacherupdate");
            routes.Add("Delete", "Teacher", "teacher/delete", "_teacherdelete");
            #endregion
            #region group
            routes.Add("List", "Group", "group/list", "_grouplist");
            routes.Add("Create", "Group", "group/create", "_groupcreate");
            routes.Add("Update", "Group", "group/update", "_groupupdate");
            routes.Add("Delete", "Group", "group/delete", "_groupdelete");
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    public static class RouteExtensions
    {
        public static Route Add(this RouteCollection collection, string action, string controller, string url, string routeName)
        {
            return collection.MapRoute(
                routeName,
                url,
                new { controller = controller, action = action },
                new[] { "Studenter.Controllers.EntityControllers" });
        }
    }
}