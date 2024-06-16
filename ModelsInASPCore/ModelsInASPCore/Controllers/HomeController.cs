using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;
using System.Diagnostics;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudent();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public IActionResult Index()
        {
            //var students = new List<Student>
            //{
            //    new Student {RollNo = 1, Name="Suyog", Gender = "Male", Standard = 12},
            //    new Student {RollNo = 2, Name="Neha", Gender = "Female", Standard = 11},
            //    new Student {RollNo = 3, Name="Natasha", Gender = "Female", Standard = 11},
            //    new Student {RollNo = 4, Name="Amrit", Gender = "Female", Standard = 10}
            //};

            //ViewData["myStudents"] = students;

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
