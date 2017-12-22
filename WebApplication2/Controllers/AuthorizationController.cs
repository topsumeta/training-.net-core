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

        [HttpPost]
        public IActionResult index([FromBody] UserViewModel model)
        {

            var user = model;


            return Ok();
        }


        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }

        
        [HttpPost]
        public IActionResult Login(UserViewModel model)
        {

            HttpContext.Session.SetString("username", model.username);

            var user = model;


            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }


        public IActionResult Logout()
        {

            HttpContext.Session.Remove("username");


            return View();
        }


    }
}
