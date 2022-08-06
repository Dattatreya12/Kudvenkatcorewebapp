using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedNewColumnHandLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HandLoanID",
                table: "employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HandLoans",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HandLoanId = table.Column<int>(nullable: false),
                    HandLoanAmount = table.Column<double>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    LoanUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandLoans", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_HandLoanID",
                table: "employees",
                column: "HandLoanID");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_HandLoans_HandLoanID",
                table: "employees",
                column: "HandLoanID",
                principalTable: "HandLoans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_HandLoans_HandLoanID",
                table: "employees");

            migrationBuilder.DropTable(
                name: "HandLoans");

            migrationBuilder.DropIndex(
                name: "IX_employees_HandLoanID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "HandLoanID",
                table: "employees");
        }
    }
}
