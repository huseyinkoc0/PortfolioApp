using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {

        ServiceManager sm = new ServiceManager(new EfService());
        public IViewComponentResult Invoke()
        {

            var values =sm.TGetList();


            return View(values);
        }

    }
}
