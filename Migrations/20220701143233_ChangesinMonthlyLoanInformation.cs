using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class ChangesinMonthlyLoanInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalPaidEmi",
                table: "MonthlyloanInformation",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalPaidEmi",
                table: "MonthlyloanInformation",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
