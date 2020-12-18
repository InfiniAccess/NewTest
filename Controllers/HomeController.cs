using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefNDish.Models;
using ChefNDish.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ChefNDish.Controllers
{
    public class HomeController : Controller
    {

        private HomeContext _context;
        public HomeController(HomeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(c => c.ChefDishes).ToList();
            return View();
        }


        [HttpGet("chef")]

        public IActionResult Chef()
        {
            return View();
        }


        [HttpPost("addChef")]

        public IActionResult AddChef(Chef nChef)
        {
            if (ModelState.IsValid)
            {
                _context.Chefs.Add(nChef);
                _context.SaveChanges();
                Console.WriteLine("Added Chef!");
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("dish")]

        public IActionResult Dish()
        {
            ViewBag.Chefs = _context.Chefs.ToList();
            return View();
        }

        [HttpPost("addDish")]

        public IActionResult AddDish(Dish nDish)
        {
            if (ModelState.IsValid)
            {
                _context.Dishes.Add(nDish);
                _context.SaveChanges();
                Console.WriteLine("Added Dish!");
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
