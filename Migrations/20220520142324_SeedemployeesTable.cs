using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class SeedemployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Active", "Department", "Email", "Name" },
                values: new object[] { 5, 1, 2, "dh@gmail.com", "Dhriti" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
