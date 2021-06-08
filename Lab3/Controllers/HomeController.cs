using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Lab3.Models;

/********************************
Student name:   Asim Jasarevic
Student number:	040922815
Section:        CST8359_303
Lab:			Lab 3 – Razor and Request/Session
File :          HomeController.cs
Purpose:        Handles any incoming URL request.

 ********************************/

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }  

        [HttpGet]
        [HttpPost]
        public IActionResult Razor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Count()
        {
            //becasue using seesion set is called
            HttpContext.Session.SetString("bottleNum", Request.Form["bottleNum"]);
            return View();
        }

        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            //becasue using Person model no need of set/get call here
            return View(person);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
