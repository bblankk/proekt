using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlorynType1.Data;
using FlorynType1.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace FlorynType1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;  // Declare the DbContext

        // Inject the DbContext via constructor
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;  // Assign DbContext to the private field
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: Authors
        public async Task<IActionResult> Meow()
        {
            // Retrieve a list of authors' names (assuming 'Title' is the author's name)
            var authorNames = await _context.Author
                                             .Select(a => a.Title)  // Select only the author's title/name
                                             .ToListAsync();

            // Get the count of authors
            int authorCount = authorNames.Count;

            // Pass the author count to the View
            ViewData["AuthorCount"] = authorCount;

            // Pass the list of author names to the View
            return View(authorNames);
        }
    }
}
