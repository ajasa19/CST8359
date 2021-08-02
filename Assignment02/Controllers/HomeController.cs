using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Data;

/*
    Student name:   Asim Jasarevic
    Student number:	040922815
    Section:        CST8359_303
    Lab:			Lab 4 – The Entity Framework 
    File:           HomeController.cs
    Purpose:        Configure routes to index and error page
*/

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(); // No need to change this line
        }

    }
}
