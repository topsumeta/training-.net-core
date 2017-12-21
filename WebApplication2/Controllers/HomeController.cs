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
    public class HomeController : Controller
    {

        private readonly IConfiguration config; 


        public HomeController(IConfiguration configuration)
        {
            config = configuration;
        }

        public IActionResult Index()
        {
            var key = config.GetValue<string>("Key");
            var data1 = config.GetValue<string>("Data:D1");
        
            var exten = config.GetSection("Extensions").GetChildren().Select(x => x.Value).ToList();

            var Mode = config.GetValue<string>("Mode");

            return View();
        }

        public IActionResult status()
        {
            return Ok();
        }

        [Route("Home/Route")]
        public IActionResult TestRoute()
        {
       

            return View();
        }

        [Route("Home/Route/{id}")]
        public IActionResult TestRoutePara(String id)
        {


            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
