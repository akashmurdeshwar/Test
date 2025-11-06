using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using MvcApp.Models.Items;
using System.Diagnostics;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[ActionName("Start")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("api/Home1/Privacy", Name ="PrivacyRoute")]
        public IActionResult Privacy()
        {
            var items = new List<Items> {
                new() {
                Id = 1,
                Name = "Akash",
                Age = 25,
                Department = "HR"
            },
            new() {
                Id = 2,
                Name = "Rajat",
                Age = 30,
                Department = "IT"
            },
           new() {
                Id = 3,
                Name = "Amar",
                Age = 30,
                Department = "FIN"
            }};
            return View(items);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ActionName("Start")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
