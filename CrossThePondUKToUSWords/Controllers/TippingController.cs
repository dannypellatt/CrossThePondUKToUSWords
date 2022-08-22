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



        public IActionResult IndexUK(TippingModel cal)
        {
            double a = cal.ValueBill;

            if (cal.Calculate == "Tip: 10")
            {
                cal.Result = a * 0.10;
                cal.Total = a + (a * 0.10);
            }
            if (cal.Calculate == "Tip: 15")
            {
                cal.Result = a * 0.15;
                cal.Total = a + (a * 0.15);
            }

            ViewData["result"] = cal.Result;
            ViewData["total"] = cal.Total;
            return View();
        }


        public IActionResult IndexUS(TippingModel cal)
        {
            double a = cal.ValueBill;

            if (cal.Calculate == "Tip: 15")
            {
                cal.Result = a * 0.15;
                cal.Total = a + (a * 0.15);
            }
            if (cal.Calculate == "Tip: 20")
            {
                cal.Result = a * 0.2;
                cal.Total = a + (a * 0.2);
            }
            if (cal.Calculate == "Tip: 25")
            {
                cal.Result = a * 0.25;
                cal.Total = a + (a * 0.25);
            }
            ViewData["result"] = cal.Result;
            ViewData["total"] = cal.Total;
            return View();
        }


    }
}
