using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PragyaPortfolio.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedPortfolioData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PortfolioOwners",
                columns: new[] { "Id", "Bio", "Email", "Github", "Linkedin", "Name" },
                values: new object[] { 1, "Software developer building applications with C#, ASP.NET Core and AI.", "pragya240119@gmail.com", "https://github.com/pragyaChauhan240119", "https://www.linkedin.com/in/pragya-chauhan-184a9b20a", "Pragya Chauhan" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Category", "Level", "Name" },
                values: new object[,]
                {
                    { 1, "Programming", "Intermediate", "C#" },
                    { 2, "Web Development", "Intermediate", "ASP.NET Core" },
                    { 3, "DevOps", "Intermediate", "GitHub" },
                    { 4, "Database", "Intermediate", "Entity Framework Core" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PortfolioOwners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
