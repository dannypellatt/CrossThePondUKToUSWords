﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrossThePondUKToUSWords.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult IndexUK()
        {
            return View();
        }
        public IActionResult IndexUS()
        {
            return View();
        }
    }
}

