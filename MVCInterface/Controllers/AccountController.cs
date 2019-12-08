using MVCInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCInterface.Controllers
{
    public class AccountController : Controller
    {
        //Вход Пользователя
        public ActionResult Login() //get version
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model) //post version
        {
            if (ModelState.IsValid) //check correct input
            {
                User user = null;
                using (UserContext db = new UserContext())
                {
                    //try to get user from DB:
                    user = db.Users.FirstOrDefault(u => u.Email == model.Name && u.Password == model.Password);
                }
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true); //setup auth cookies
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View(model);
        }

        //Регистрация пользователя
        public ActionResult Register() //get version
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model) //post version
        {
            if (ModelState.IsValid) //check correct input
            {
                User user = null;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Name); //search user by login
                }
                if (user == null)
                {
                    // create new user
                    using (UserContext db = new UserContext())
                    {
                        db.Users.Add(new User { Email = model.Name, Password = model.Password, Age = model.Age, RoleId = 2 });
                        db.SaveChanges();

                        //try to get user from DB:
                        user = db.Users.Where(u => u.Email == model.Name && u.Password == model.Password).FirstOrDefault();
                    }
                    // if user added to DB successfully
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true); //setup auth cookies
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }

        //Выход пользователя
        public ActionResult Logoff() //Метод, отправляющий на страницу разлогинивания
        {    
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logoff(Confirmation model) //Метод выхода из системы
        {

            if (model.Confirm)
            {
                LoginModel.Logoff();
            }

            return RedirectToAction("Index", "Home"); //Перенаправление на начальную страницу
        }
    }
}