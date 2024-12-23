using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolio());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje listesi";
            ViewBag.v2 = "Projeler ";
            ViewBag.v3 = "Proje Listesi";
            var values=portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje listesi";
            ViewBag.v2 = "Projeler ";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio) 
        {

            portfolioManager.TAdd(portfolio);

            return RedirectToAction("Index");
        }
    }
}
