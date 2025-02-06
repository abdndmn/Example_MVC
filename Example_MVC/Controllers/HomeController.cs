using Microsoft.AspNetCore.Mvc;

namespace Example_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
