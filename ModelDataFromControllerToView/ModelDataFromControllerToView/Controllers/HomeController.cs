using Microsoft.AspNetCore.Mvc;
using ModelDataFromControllerToView.Models;
using System.Diagnostics;

namespace ModelDataFromControllerToView.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Suyog",
            //    Designation = "Manager",
            //    Salary = 50000
            //};

            var myEmployees = new List<Employee>
            {
                new Employee {EmpId = 101, EmpName="Suyog", Designation="Manager", Salary=5000 },
                new Employee {EmpId = 102, EmpName="Prakriti", Designation="Accountant", Salary=2000 },
                new Employee {EmpId = 103, EmpName="Divya", Designation="Developer", Salary=6000 },
                new Employee {EmpId = 104, EmpName="Pooja", Designation="HR", Salary=8000 },
            };

            //ViewData["myEmployee"] = myEmployees;
            //ViewBag.myEmployee = myEmployees;
            TempData["myEmployee"] = myEmployees;

            //ViewData["myEmployee"] = emp;
            //ViewBag.myEmployee = emp;
            //TempData["myEmployee"] = emp;

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
