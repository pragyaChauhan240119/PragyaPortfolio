using Microsoft.AspNetCore.Mvc;
using PragyaPortfolio.Web.Data;

namespace PragyaPortfolio.Web.Controllers
{
    public class SkillsController : Controller
    {
        private readonly PortfolioDbContext _context;

        public SkillsController(PortfolioDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var skills = _context.Skills.ToList();
            return View(skills);
        }
    }
}