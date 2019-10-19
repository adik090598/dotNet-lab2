using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_Labka2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult PlusTen(int number)
        {
            ViewData["number"] = number;
            ViewData["result"] = number + 10;

            return View();
        }
    }
}