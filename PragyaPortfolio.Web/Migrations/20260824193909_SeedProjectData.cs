using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PragyaPortfolio.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedProjectData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "GithubLink", "LiveDemoLink", "Name", "Technologies" },
                values: new object[] { 1, "An ASP.NET Core MVC portfolio application built to showcase technical skills, projects and learning journey.", "https://github.com/pragyaChauhan240119", "", "PragyaPortfolio", "[\"C#\",\"ASP.NET Core\",\"Entity Framework Core\",\"SQLite\",\"Git\",\"GitHub\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
