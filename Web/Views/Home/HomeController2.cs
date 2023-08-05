using Microsoft.AspNetCore.Mvc;

namespace Web.Views.Home
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
