using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class LoanEmployeeDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loanEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanID = table.Column<string>(nullable: false),
                    TotalLoanAmount = table.Column<int>(nullable: false),
                    TotalEmi = table.Column<int>(nullable: false),
                    TotalIntrest = table.Column<int>(nullable: false),
                    Active = table.Column<int>(nullable: false),
                    LoanDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanEmployees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loanEmployees");
        }
    }
}
