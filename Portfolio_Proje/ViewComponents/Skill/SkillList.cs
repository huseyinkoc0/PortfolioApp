using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        public class Ska { }
        SkillManager skillManager=new SkillManager(new EfSkill());
        public IViewComponentResult Invoke() 
        {
            var values = skillManager.TGetList();
        
            
            
            
            return View(values);
        }
    }
}
