using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IViewComponentResult Invoke() 
        {
            var values=featureManager.TGetList();
            return View(values);
        }
    }
}
