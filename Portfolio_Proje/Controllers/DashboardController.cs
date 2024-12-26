using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
