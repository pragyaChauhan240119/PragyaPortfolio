using Microsoft.EntityFrameworkCore;
using PragyaPortfolio.Web.Models;

namespace PragyaPortfolio.Web.Data;

public class PortfolioDbContext : DbContext
{
   public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
    : base(options)
{
}

    public DbSet<PortfolioOwner> PortfolioOwners { get; set; }
    public DbSet<Skill> Skills { get; set; }
}