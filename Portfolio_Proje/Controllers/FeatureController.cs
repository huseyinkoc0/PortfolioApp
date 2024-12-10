using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
