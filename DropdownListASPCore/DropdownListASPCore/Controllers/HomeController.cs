using DropdownListASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DropdownListASPCore.Controllers
{
    public enum Gender
    {
        Male, Female
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SelectListItem> Gender = new()
            {
                new SelectListItem {Value = "Male", Text = "Male" },
                new SelectListItem {Value = "Female", Text = "Female" },
                new SelectListItem {Value = "Others", Text = "Others" }
            };

            ViewBag.Gender = Gender;
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
