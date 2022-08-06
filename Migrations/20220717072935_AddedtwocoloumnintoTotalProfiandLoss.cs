using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedtwocoloumnintoTotalProfiandLoss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Totalloss",
                table: "TotalProfiLoss",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Totalprofit",
                table: "TotalProfiLoss",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Totalloss",
                table: "TotalProfiLoss");

            migrationBuilder.DropColumn(
                name: "Totalprofit",
                table: "TotalProfiLoss");
        }
    }
}
