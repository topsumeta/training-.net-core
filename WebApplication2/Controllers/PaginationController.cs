using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PaginationController : Controller
    {

        public IActionResult Index()
        {
            string page = HttpContext.Request.Query["id"].ToString();

            var pagModel = new PaginationViewModel();

            pagModel.start = 1;
            pagModel.stop = 5;

            if (page != null && page != "")
            {
                pagModel.number = Int32.Parse(page);
                pagModel.start = pagModel.number - 2;
                pagModel.stop = pagModel.number + 2;
                if (pagModel.start <=0)
                {
                    pagModel.start = 1;
                    pagModel.stop = 5;
                }
            }


            return View(pagModel);
        }


   

    }
}