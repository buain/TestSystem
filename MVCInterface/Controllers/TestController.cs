﻿using AutoMapper;
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
        
        ITestLogic testLogic;
        public TestController(ITestLogic logic)
        {
            testLogic = logic;
        }
        //public ActionResult TestsList() // Вывод списка тестов
        //{
        //    IEnumerable<TestDTO> testDTOs = testLogic.GetAll();
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TestDTO, Test>()).CreateMapper();
        //    var testList = mapper.Map<IEnumerable<TestDTO>, List<Test>>(testDTOs);
        //    //ViewBag.Tests = tests;
        //    return View(testList);
        //}
        //GET: Добавление теста
        [Authorize(Roles = "Admin")]
        
        public ActionResult Create()
        {
            return PartialView("Create");
        }
        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(TestDTO testDTO)
        {
            //
            return RedirectToAction("TestList");
        }

        //GET: Изменение теста
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {
            return PartialView("Edit");
        }
        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(TestDTO testDTO)
        {
            //
            return RedirectToAction("TestList");
        }
        //GET: Удаление теста
        [Authorize(Roles = "Admin")]
        public ActionResult Delete()
        {
            return PartialView("Delete");
        }
        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(TestDTO testDTO)
        {
            //
            return RedirectToAction("TestList");
        }
        //GET: Запустить тест
        public ActionResult StartTest()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult StartTest(TestDTO testDTO)
        {
            //
            return View("StartTest");
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