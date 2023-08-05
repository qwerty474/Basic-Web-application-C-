using Microsoft.AspNetCore.Mvc;

namespace Web.Views.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
