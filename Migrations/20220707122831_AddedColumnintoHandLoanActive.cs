using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedColumnintoHandLoanActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "HandLoans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalSumofAmount",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalSumofLoan",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "HandLoans");

            migrationBuilder.DropColumn(
                name: "TotalSumofAmount",
                table: "DashBoardViewModel");

            migrationBuilder.DropColumn(
                name: "TotalSumofLoan",
                table: "DashBoardViewModel");
        }
    }
}
