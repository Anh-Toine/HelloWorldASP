using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldASP.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
<<<<<<< HEAD
            ViewBag.Fifteen = 0.0M;
            ViewBag.Twenty = 0.0M;
            ViewBag.TwentyFive = 0.0M;
=======
            ViewBag.Discount = 0.0;
            ViewBag.Total = 0.0;
>>>>>>> 4122eda (First commit)
            return View();
        }
        

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            // If the state is valid, calculate the discount amount and the total.
            // Otherwise, set them to 0.
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                ViewBag.Fifteen = calc.CalculateTip(15);
                ViewBag.Twenty = calc.CalculateTip(20);
                ViewBag.TwentyFive = calc.CalculateTip(25);
            }
            else
            {
                ViewBag.Fifteen = 0.0M;
                ViewBag.Twenty = 0.0M;
                ViewBag.TwentyFive = 0.0M;
=======
                ViewBag.Discount = calc.DiscountAmountCalculate();
                ViewBag.Total = calc.TotalCalculate();
            }
            else
            {
                ViewBag.Discount = 0.0;
                ViewBag.Total = 0.0;
>>>>>>> 4122eda (First commit)
            }
            return View(calc);
        }
    }
}
