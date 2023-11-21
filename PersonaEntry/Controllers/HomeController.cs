using Microsoft.AspNetCore.Mvc;
using PersonaEntry.Models;
using System.Diagnostics;

namespace PersonaEntry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PersonInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostPersonInfo(Person person)
        {
            // Save the person data or do whatever you need
            // Redirect to a new page (PersonAdded) with the submitted data
            return RedirectToAction("PersonAdded", person);
        }

        public IActionResult PersonAdded(Person person)
        {
            // Display the Person data
            return View(person);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}