using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossThePondUKToUSWords.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrossThePondUKToUSWords.Controllers
{
    public class TempController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(TempModel cal)
        {
            double a = cal.valueTemp;

            if (cal.calculate == "Fahrenheit to Celcius")
            {
                cal.result = (a - 32) / 1.8;

            }
            if (cal.calculate == "Celcius to Fahrenheit")
            {
                cal.result = (a * 9) / 5 + 32;

            }
            ViewData["result"] = Math.Round(cal.result, 1);
            return View();
        }

        public IActionResult IndexUS(TempModel cal)
        {
            double a = cal.valueTemp;

            if (cal.calculate == "Fahrenheit to Celcius")
            {
                cal.result = (a - 32) * (5 / 9);

            }
            if (cal.calculate == "Celcius to Fahrenheit")
            {
                cal.result = (a * 9) / 5 + 32;

            }

            ViewData["result"] = Math.Round(cal.result, 1);
            return View();
        }
    }
}

