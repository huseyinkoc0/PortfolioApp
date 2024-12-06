using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_Proje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager _contactManager = new ContactManager(new EfContact());
        public IViewComponentResult Invoke()
        {
            var values=_contactManager.TGetList();
            return View(values);
        }
    }
}
