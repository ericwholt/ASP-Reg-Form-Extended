using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Reg_Form.Models;

namespace ASP_Reg_Form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Summary(User user)
        {
            ViewBag.FullName = user.FullName;
            //ViewBag.Email = user.Email;
            //ViewBag.UserName = user.UserName;
            //ViewBag.Password = user.Password;
            return View();
        }
    }
}