using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestP.WebAppDemo.Models;

namespace TestP.WebAppDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            string id = new Random().Next(0, 2).ToString();
            var blagoja = new Human
            {
                FirstName = "blagoja",
                LastName = "trajkovski",
                Id = "0"
            };
            var dzevat = new Human
            {
                FirstName = "dzevat",
                LastName = "ibraimi",
                Id = "1"
            };

            if(id == "1")
            {
                return View(blagoja);
            }
            return View(dzevat);
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
            return View();
        }
    }
}
