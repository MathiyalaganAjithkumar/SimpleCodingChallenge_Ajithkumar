using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCodingChallenge.DataAccess.Migrations
{
    public partial class country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
   name: "country",
   table: "Employees",
   nullable: false,
   defaultValue: 0);     }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
              name: "country",
            table: "Employees");
        }
    }
}
