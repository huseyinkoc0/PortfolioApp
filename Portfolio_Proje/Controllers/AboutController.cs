using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class AboutController : Controller
    {
        
            AboutManager aboutManager = new AboutManager(new EfAboutDal
                ());
            public IActionResult Index()
            {
                ViewBag.v1 = "Hakkımda ";
                ViewBag.v2 = "Hakkımda";
                ViewBag.v3 = "Hakkımda Sayfası";
                var values = aboutManager.TGetById(4);
                return View(values);
            }
            [HttpPost]
            public IActionResult Index(About about)
            {

                aboutManager.TUpdate(about);
                return RedirectToAction("Index", "Default");
            }
        
    }
}
