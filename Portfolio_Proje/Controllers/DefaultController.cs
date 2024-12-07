using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial() 
        { 

          return NavbarPartial();
        }
        [HttpGet]
        public PartialViewResult SendMessage() 
        {



            return SendMessage(); 
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager mg = new MessageManager(new EfMessage());
            p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            mg.TAdd(p);

            return SendMessage();
        }
    }
}
