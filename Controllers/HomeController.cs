using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
