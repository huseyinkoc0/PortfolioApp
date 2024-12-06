using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent

    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonial());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
