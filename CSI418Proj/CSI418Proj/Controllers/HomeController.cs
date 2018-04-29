using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using CSI418Proj.Models;

namespace CSI418Proj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            var userId = User.Identity.GetUserId();
            var manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindById(userId);

            //direct to standarddash if standard user & logged in
            if (User.Identity.IsAuthenticated && user.UserType != null && user.UserType.CompareTo("standard") == 0)
            {
                return View("../Dashboard/StandardDash");
            }
            //direct to admindash if admin user & logged in
            else if (User.Identity.IsAuthenticated && user.UserType != null && user.UserType.CompareTo("admin") == 0)
            {
                return View("../DashBoard/AdminDash");
            }
            else
            {
                return View();
        }
    }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}