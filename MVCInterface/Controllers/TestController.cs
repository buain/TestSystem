using AutoMapper;
using MVCInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSystem.BLL.DTO;
using TestSystem.BLL.Interfaces;

namespace MVCInterface.Controllers
{
    public class TestController : Controller
    {
        // GET:
        UserContext db = new UserContext();
        //public ActionResult TestsList()
        //{
        //    IEnumerable<Models.Test> tests = db.Tests;
        //    ViewBag.Tests = tests;
        //    return View();
        //}
        ITestLogic testLogic;
        public TestController(ITestLogic logic)
        {
            testLogic = logic;
        }
        public ActionResult TestsList() // Вывод списка тестов
        {
            IEnumerable<TestDTO> testDTOs = testLogic.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TestDTO, Test>()).CreateMapper();
            var testList = mapper.Map<IEnumerable<TestDTO>, List<Test>>(testDTOs);
            //ViewBag.Tests = tests;
            return View(testList);
        }
        //GET:
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }
        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Models.Test model)
        {
            if (ModelState.IsValid)
            {
                Models.Test.Create(model);
                return RedirectToAction("TestsList");
            }

            return View(model);
        }
        //GET:
        [Authorize(Roles = "Admin")]
        public ActionResult Change()
        {
            return View();
        }
        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Change(Models.Test model)
        {
            //

            return View(model);
        }
        public ActionResult StartTest()
        {
            return View();
        }
        public ActionResult StartTest(Models.Test model)
        {
            //

            return View(model);
        }
        [HttpGet]
        public ActionResult Test1()
        {
            return View();
        }
        public void ResultTest1(string Test1Answer1, string Test1Answer2, string Test1Answer3)
        {
            
        }

    }
}