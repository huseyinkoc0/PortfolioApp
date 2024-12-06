using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager PortfolioManager = new PortfolioManager(new EfPortfolio());
        public IViewComponentResult Invoke()
        {
            var values= PortfolioManager.TGetList();

            return View(values);
        }
    }
}
