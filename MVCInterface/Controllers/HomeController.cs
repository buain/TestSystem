using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCInterface.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("IndexLogined"); //result = "Ваш логин: " + User.Identity.Name;
            }
            return View();
        }

        [Authorize]
        public ActionResult Tests()
        {
            ViewBag.Message = "Страница прохождения тестов.";

            return View();
        }

        [Authorize]
        public ActionResult Results()
        {
            ViewBag.Message = "Результаты тестов.";

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Control()
        {
            ViewBag.Message = "Панель управления.";

            return View();
        }
    }
}