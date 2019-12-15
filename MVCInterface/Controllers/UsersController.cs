using MVCInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCInterface.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        //Показатть список всех пользователей
      
        UserContext db = new UserContext();
        public ActionResult GetAllUsers()
        {
            IEnumerable<Models.User> users = db.Users;
            ViewBag.Users = users;
            return View();
        }

        //public ActionResult GetAllUsers()
        //{
        //    var model = User.GetAllUsers();
        //    return View(model);
        //}
    }
}