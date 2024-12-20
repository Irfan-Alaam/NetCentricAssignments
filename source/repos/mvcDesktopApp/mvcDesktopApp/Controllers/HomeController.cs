using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcDesktopApp.Models;

namespace mvcDesktopApp.Controllers
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

        public IActionResult Contact()
        {
            Contact ct = new Contact()
            {
                City = "kathmandu",
                Street = "bafal",
                PostalCode = "17"
            };
            ViewData["contact"] = ct;
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
    }
}
