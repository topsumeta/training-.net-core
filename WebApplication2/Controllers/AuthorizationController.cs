using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class AuthorizationController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }

        
        [HttpPost]
        public IActionResult Login(UserViewModel model)
        {
            HttpContext.Session.SetString("username", model.username);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Signup()
        {
            return View();
        }


        public IActionResult Logout()
        {

            HttpContext.Session.Remove("username");


            return RedirectToAction("Index", "Home");
        }


    }
}
