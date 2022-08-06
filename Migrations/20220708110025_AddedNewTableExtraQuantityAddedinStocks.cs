using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedNewTableExtraQuantityAddedinStocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanDate",
                table: "loanEmployees",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalSumofHandloanAmount",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ExtraQuantityAddedinStocks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrokerName = table.Column<string>(nullable: true),
                    StockName = table.Column<string>(nullable: true),
                    BuyPrice = table.Column<double>(nullable: false),
                    TotalShare = table.Column<int>(nullable: false),
                    TotalInvestment = table.Column<double>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraQuantityAddedinStocks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraQuantityAddedinStocks");

            migrationBuilder.DropColumn(
                name: "TotalSumofHandloanAmount",
                table: "DashBoardViewModel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanDate",
                table: "loanEmployees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
