using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddinTotalProfiLoss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DashBoardViewModelId",
                table: "LoanTracks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GetCurrenctMonth",
                table: "DashBoardViewModel",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TotalProfiLoss",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profit = table.Column<double>(nullable: false),
                    Loss = table.Column<double>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalProfiLoss", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanTracks_DashBoardViewModelId",
                table: "LoanTracks",
                column: "DashBoardViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanTracks_DashBoardViewModel_DashBoardViewModelId",
                table: "LoanTracks",
                column: "DashBoardViewModelId",
                principalTable: "DashBoardViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanTracks_DashBoardViewModel_DashBoardViewModelId",
                table: "LoanTracks");

            migrationBuilder.DropTable(
                name: "TotalProfiLoss");

            migrationBuilder.DropIndex(
                name: "IX_LoanTracks_DashBoardViewModelId",
                table: "LoanTracks");

            migrationBuilder.DropColumn(
                name: "DashBoardViewModelId",
                table: "LoanTracks");

            migrationBuilder.DropColumn(
                name: "GetCurrenctMonth",
                table: "DashBoardViewModel");
        }
    }
}
