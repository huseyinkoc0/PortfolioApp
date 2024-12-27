using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IActionResult Index()
        {

            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Öne çıkarılanlar";
            ViewBag.v3 = "Öne çıkarılanlar";
            var values = featureManager.TGetById(1);
            return View(values);
        }
         
           
        [HttpPost]
        public IActionResult Index(Feature feature)
        {

            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
