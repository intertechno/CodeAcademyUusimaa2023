using AspNetMvcLaskin.Entities;
using AspNetMvcLaskin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetMvcLaskin.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }







        public string SanoMoi()
        {
            return "Moi!";
        }

        public IActionResult Testinäkymä()
        {
            //Asiakas data = new()
            //{
            //    Nimi = "Matti Möttönen",
            //    Osoite = "Mäkitie 1",
            //    Puhelin = "040 123 4567"
            //};

            NorthwindContext context = new();
            Customer eka = context.Customers.First();

            Asiakas data = new()
            {
                Nimi = eka.ContactName ?? "",
                Osoite = eka.Address ?? "",
                Puhelin = eka.Phone ?? ""
            };

            return View(data);
        }
    }
}
