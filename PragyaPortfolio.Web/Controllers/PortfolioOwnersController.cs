using Microsoft.AspNetCore.Mvc;
using PragyaPortfolio.Web.Data;    

namespace PragyaPortfolio.Web.Controllers
{
    public class PortfolioOwnersController : Controller
    {
        private readonly PortfolioDbContext _context;

        public PortfolioOwnersController(PortfolioDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var portfolioOwner = _context.PortfolioOwners.FirstOrDefault();
            return View(portfolioOwner);
        }
    }
}