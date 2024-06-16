using Microsoft.AspNetCore.Mvc;
using StronglyTypedViews.Models;
using System.Diagnostics;

namespace StronglyTypedViews.Controllers
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
            //    Salary = 5000
            //};

            var myEmployees = new List<Employee>
            {
                new Employee {EmpId = 1, EmpName="Suyog", Designation="Manager", Salary=25000 },
                new Employee {EmpId = 2, EmpName="Divya", Designation="HR", Salary=5000 },
                new Employee {EmpId = 3, EmpName="Anupriya", Designation="Supervisor", Salary=10000 }

            };

            return View(myEmployees);
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
