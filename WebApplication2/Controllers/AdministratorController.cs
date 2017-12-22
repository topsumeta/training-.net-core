using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [Authorize(Policy = "Administrator")]
    public class AdministratorController : Controller
    {
      
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Signup()
        {
            return View();
        }


        public IActionResult Logout()
        {
            return Ok();
        }







    }
}
