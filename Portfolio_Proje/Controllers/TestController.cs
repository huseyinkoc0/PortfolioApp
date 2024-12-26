using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
