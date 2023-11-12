using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class Addextraquantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TradeinformationId",
                table: "ExtraQuantityAddedinStocks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "brokerid",
                table: "ExtraQuantityAddedinStocks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stockid",
                table: "ExtraQuantityAddedinStocks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Active = table.Column<int>(nullable: false),
                    Department = table.Column<int>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    InitialName = table.Column<string>(nullable: true),
                    TotalInvestedAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDTO", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExtraQuantityAddedinStocks_TradeinformationId",
                table: "ExtraQuantityAddedinStocks",
                column: "TradeinformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraQuantityAddedinStocks_brokerid",
                table: "ExtraQuantityAddedinStocks",
                column: "brokerid");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraQuantityAddedinStocks_tradeinformations_TradeinformationId",
                table: "ExtraQuantityAddedinStocks",
                column: "TradeinformationId",
                principalTable: "tradeinformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraQuantityAddedinStocks_brokers_brokerid",
                table: "ExtraQuantityAddedinStocks",
                column: "brokerid",
                principalTable: "brokers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraQuantityAddedinStocks_tradeinformations_TradeinformationId",
                table: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraQuantityAddedinStocks_brokers_brokerid",
                table: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropTable(
                name: "EmployeeDTO");

            migrationBuilder.DropIndex(
                name: "IX_ExtraQuantityAddedinStocks_TradeinformationId",
                table: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropIndex(
                name: "IX_ExtraQuantityAddedinStocks_brokerid",
                table: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropColumn(
                name: "TradeinformationId",
                table: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropColumn(
                name: "brokerid",
                table: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropColumn(
                name: "stockid",
                table: "ExtraQuantityAddedinStocks");
        }
    }
}
