using Microsoft.AspNetCore.Mvc;
using Mission3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calc(Calculator_Entries calc_model)
        {
            return View();
        }
    }
}
