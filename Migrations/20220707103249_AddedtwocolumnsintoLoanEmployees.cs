using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedtwocolumnsintoLoanEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DashBoardViewModelId",
                table: "MonthlyloanInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DashBoardViewModelId",
                table: "loanEmployees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TatlBalanceEmi",
                table: "loanEmployees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPaidEmi",
                table: "loanEmployees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DashBoardViewModelId",
                table: "HandLoans",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DashBoardViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoardViewModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyloanInformation_DashBoardViewModelId",
                table: "MonthlyloanInformation",
                column: "DashBoardViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_loanEmployees_DashBoardViewModelId",
                table: "loanEmployees",
                column: "DashBoardViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_HandLoans_DashBoardViewModelId",
                table: "HandLoans",
                column: "DashBoardViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_HandLoans_DashBoardViewModel_DashBoardViewModelId",
                table: "HandLoans",
                column: "DashBoardViewModelId",
                principalTable: "DashBoardViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_loanEmployees_DashBoardViewModel_DashBoardViewModelId",
                table: "loanEmployees",
                column: "DashBoardViewModelId",
                principalTable: "DashBoardViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyloanInformation_DashBoardViewModel_DashBoardViewModelId",
                table: "MonthlyloanInformation",
                column: "DashBoardViewModelId",
                principalTable: "DashBoardViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandLoans_DashBoardViewModel_DashBoardViewModelId",
                table: "HandLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_loanEmployees_DashBoardViewModel_DashBoardViewModelId",
                table: "loanEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyloanInformation_DashBoardViewModel_DashBoardViewModelId",
                table: "MonthlyloanInformation");

            migrationBuilder.DropTable(
                name: "DashBoardViewModel");

            migrationBuilder.DropIndex(
                name: "IX_MonthlyloanInformation_DashBoardViewModelId",
                table: "MonthlyloanInformation");

            migrationBuilder.DropIndex(
                name: "IX_loanEmployees_DashBoardViewModelId",
                table: "loanEmployees");

            migrationBuilder.DropIndex(
                name: "IX_HandLoans_DashBoardViewModelId",
                table: "HandLoans");

            migrationBuilder.DropColumn(
                name: "DashBoardViewModelId",
                table: "MonthlyloanInformation");

            migrationBuilder.DropColumn(
                name: "DashBoardViewModelId",
                table: "loanEmployees");

            migrationBuilder.DropColumn(
                name: "TatlBalanceEmi",
                table: "loanEmployees");

            migrationBuilder.DropColumn(
                name: "TotalPaidEmi",
                table: "loanEmployees");

            migrationBuilder.DropColumn(
                name: "DashBoardViewModelId",
                table: "HandLoans");
        }
    }
}
