using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class Addprofitloss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AddProfitLosses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Option = table.Column<string>(nullable: true),
                    IncomeLoss = table.Column<float>(nullable: false),
                    Createat = table.Column<DateTime>(nullable: false),
                    Active = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddProfitLosses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonthlytotlaLoanCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    toatlloancountmonthly = table.Column<int>(nullable: false),
                    DashBoardViewModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlytotlaLoanCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlytotlaLoanCount_DashBoardViewModel_DashBoardViewModelId",
                        column: x => x.DashBoardViewModelId,
                        principalTable: "DashBoardViewModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthlytotlaLoanCount_DashBoardViewModelId",
                table: "MonthlytotlaLoanCount",
                column: "DashBoardViewModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddProfitLosses");

            migrationBuilder.DropTable(
                name: "MonthlytotlaLoanCount");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "DashBoardViewModel");
        }
    }
}
