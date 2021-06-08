using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Lab3.Models;

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
            return View(person);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
