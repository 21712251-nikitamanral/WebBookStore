using Microsoft.AspNetCore.Mvc;

namespace WebBookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
