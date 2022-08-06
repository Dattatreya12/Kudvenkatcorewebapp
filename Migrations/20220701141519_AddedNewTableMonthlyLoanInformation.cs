using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedNewTableMonthlyLoanInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoanStatus",
                table: "loanEmployees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MonthlyloanInformation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanID = table.Column<string>(nullable: true),
                    MonthEmiAmount = table.Column<double>(nullable: false),
                    TotalPaidEmi = table.Column<double>(nullable: false),
                    LoanEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyloanInformation", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyloanInformation");

            migrationBuilder.DropColumn(
                name: "LoanStatus",
                table: "loanEmployees");
        }
    }
}
