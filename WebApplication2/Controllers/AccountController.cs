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
    [Authorize]
    public class AccountController : Controller
    {
      
        [AllowAnonymous]
        public ActionResult Login()
        {
            return Ok();
        }

        public ActionResult Logout()
        {
            return Ok();
        }







    }
}
