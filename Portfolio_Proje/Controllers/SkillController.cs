using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkill());
        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
