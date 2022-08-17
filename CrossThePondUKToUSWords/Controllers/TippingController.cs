using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossThePondUKToUSWords.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrossThePondUKToUSWords.Controllers
{
    public class TippingController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(TippingModel cal)
        {
            double a = cal.valueBill;

            if (cal.calculate == "Tip: 10")
            {
                cal.result = a * 0.10;
            }
            if (cal.calculate == "Tip: 15")
            {
                cal.result = a * 0.15;
            }
            if (cal.calculate == "Tip: 20")
            {
                cal.result = a * 0.2;
            }
            if (cal.calculate == "Tip: 25")
            {
                cal.result = a * 0.25;
            }
            ViewData["result"] = cal.result;
            return View();
        }


    }
}
