using Microsoft.AspNetCore.Mvc;

namespace PragyaPortfolio.Web.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            var skills  = new List<Models.Skill>
            {
                new Models.Skill
                {Name = "Git",
                Category = "DevOps",
                Level = "Beginner"},

                new Models.Skill{ Name = "GitHub",
                Category = "DevOps",
                Level = "Beginner"},

                new Models.Skill{ Name = "ASP.NET Core",
                Category = "Backend",
                Level = "Learning"},

                new Models.Skill{  Name = "C#",
                Category = "Backend",
                Level = "Learning"}


            };
            return View(skills);
        }
    }
}