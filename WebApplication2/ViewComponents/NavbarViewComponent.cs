using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int maxPriorty,bool isDone)
        {
            int model = 1;

            return View(model);
        }


     
    }
}
