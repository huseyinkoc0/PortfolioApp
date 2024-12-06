using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
