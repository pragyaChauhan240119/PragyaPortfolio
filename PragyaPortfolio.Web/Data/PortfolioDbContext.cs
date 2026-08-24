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
    public DbSet<Project> Projects { get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PortfolioOwner>().HasData(
            new PortfolioOwner
            {
                Id = 1,
                Name = "Pragya Chauhan",
                Email = "pragya240119@gmail.com",
                Linkedin ="https://www.linkedin.com/in/pragya-chauhan-184a9b20a",
                Github = "https://github.com/pragyaChauhan240119",
                Bio = "Software developer building applications with C#, ASP.NET Core and AI."
            }
        );

        modelBuilder.Entity<Skill>().HasData(
            new Skill
            {
                Id = 1,
                Name = "C#",
                Category = "Programming",
                Level = "Intermediate"
            },
            new Skill
            {
                Id = 2,
                Name = "ASP.NET Core",
                Category = "Web Development",
                Level = "Intermediate"
            },
            new Skill
            {
                Id = 3,
                Name = "GitHub",
                Category = "DevOps",
                Level = "Intermediate"
            },
            new Skill
            {
                Id = 4,
                Name = "Entity Framework Core",
                Category = "Database",
                Level = "Intermediate"
            }
        );
        modelBuilder.Entity<Project>().HasData(
            new Project
            {
               Id = 1,
               Name = "PragyaPortfolio",
               Description = "An ASP.NET Core MVC portfolio application built to showcase technical skills, projects and learning journey.",
               Technologies = new List<string>
               {
                 "C#",
                 "ASP.NET Core",
                 "Entity Framework Core",
                 "SQLite",
                 "Git",
                 "GitHub"
              },
               GithubLink = "https://github.com/pragyaChauhan240119",
               LiveDemoLink = ""
            }
    );
    }
}