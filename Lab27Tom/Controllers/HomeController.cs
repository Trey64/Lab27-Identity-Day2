using Lab27Tom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Tom.Controllers
{
    public class HomeController : Controller
    {
        //private field, used for Dependendcy Injection
        private readonly Lab27TomContext _context;

        //Constructor for Home Controller - a DBContext is required
        public HomeController(Lab27TomContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Calling to the LFG table in the database and getting the content for ID 1
            var result = _context.LFG.Where(c => c.ID == 1);

            return View(result.ToList());
        }
    }
}
