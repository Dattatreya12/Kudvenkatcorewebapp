using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class createdividendinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalLoanAmount",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "dividend_Infos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stockid = table.Column<int>(nullable: false),
                    tradeinformationId = table.Column<int>(nullable: true),
                    dividendAmount = table.Column<double>(nullable: false),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dividend_Infos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dividend_Infos_tradeinformations_tradeinformationId",
                        column: x => x.tradeinformationId,
                        principalTable: "tradeinformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dividend_Infos_tradeinformationId",
                table: "dividend_Infos",
                column: "tradeinformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dividend_Infos");

            migrationBuilder.DropColumn(
                name: "TotalLoanAmount",
                table: "DashBoardViewModel");
        }
    }
}
