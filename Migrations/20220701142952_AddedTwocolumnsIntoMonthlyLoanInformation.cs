using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedTwocolumnsIntoMonthlyLoanInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "MonthlyloanInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "MonthlyloanInformation",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "MonthlyloanInformation");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "MonthlyloanInformation");
        }
    }
}
