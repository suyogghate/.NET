using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    //[Route("Home")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
