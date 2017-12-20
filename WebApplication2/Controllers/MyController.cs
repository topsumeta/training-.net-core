using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {

            var myvar = new MyViewModel();


            return View(myvar);
        }

        [HttpPost]
        public IActionResult Index(string firstName)
        {

            var test = firstName;

            return Content($"Hello {firstName}");
        }
    }
}