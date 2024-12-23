using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results= validations.Validate(portfolio);
            if (results.IsValid)

            {

                portfolioManager.TAdd(portfolio);

                return RedirectToAction("Index");

            }
            else
            {
                foreach(var item in results.Errors) 
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();

        }

        public IActionResult DeletePortfolio(int id)
        {
            var values=portfolioManager.TGetById(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Proje listesi";
            ViewBag.v2 = "Projeler ";
            ViewBag.v3 = "Proje Güncelleme";
            var values = portfolioManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validator = new PortfolioValidator();
            var result=validator.Validate(portfolio);
            if (result.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }

            }
            return View();

            
        }

    }
}
