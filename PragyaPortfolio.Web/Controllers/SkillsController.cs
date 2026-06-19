using Microsoft.AspNetCore.Mvc;

namespace PragyaPortfolio.Web.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            var skills  = new List<Models.Skills>
            {
                new Models.Skills
                {Name = "Git",
                Category = "DevOps",
                Level = "Beginner"},

                new Models.Skills{ Name = "GitHub",
                Category = "DevOps",
                Level = "Beginner"},

                new Models.Skills{ Name = "ASP.NET Core",
                Category = "Backend",
                Level = "Learning"},

                new Models.Skills{  Name = "C#",
                Category = "Backend",
                Level = "Learning"}


            };
            return View(skills);
        }
    }
}