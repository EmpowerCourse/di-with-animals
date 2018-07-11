using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalDemo.Models;
using AnimalDemo.Interfaces;

namespace AnimalDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAmANoisyAnimal _noiseMerchant;

        public HomeController(IAmANoisyAnimal noiseMerchant)
        {
            _noiseMerchant = noiseMerchant;

        }

        public IActionResult Index()
        {
            ViewData["Message"]
             = $"I am a {_noiseMerchant.Species} and I {_noiseMerchant.MakeNoise()}";
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
