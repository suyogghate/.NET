using ControllersAndAction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControllersAndAction.Controllers
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
            ViewData["data1"] = "ViewData";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";

            //TempData["data4"] = new List<string>()
            //{
            //    "Cricket", "Football", "Hockey"
            //};

            TempData["data4"] = null;
            TempData.Keep("data3"); //If you want to show tempdata in all
            //the views
            return View();
        }
        
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }
        
        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//ViewData["data1"] = "Programentor";
//ViewData["data2"] = 25;
//ViewData["data3"] = DateTime.Now.ToLongDateString();

//string[] arr = { "Kumar", "Varun", "Aditya" };

//ViewData["data4"] = arr;

//ViewData["data5"] = new List<string>()
//{
//    "Cricket", "Football", "Hockey"
//};

//ViewBag
//ViewBag.data1 = "Programentor";
//ViewBag.data2 = 20;
//ViewBag.data3 = DateTime.Now.ToShortDateString();

//ViewData["myName"] = "Suyog";
//ViewBag.data6 = "Welcome to ASP .NET Core";

//int[] arr = { 20, 15, 1, 78 };
//ViewBag.data4 = arr;

//ViewBag.data5 = new List<string>()
//{
//    "Cricket", "Football", "Hockey"
//};