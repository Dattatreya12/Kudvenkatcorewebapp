using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddingnewcolumnsintoTradeinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalProfit",
                table: "tradeinformations",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotlaLoss",
                table: "tradeinformations",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "DashBoardViewModelId1",
                table: "loanEmployees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanDate",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "TotalIntrest",
                table: "DashBoardViewModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_loanEmployees_DashBoardViewModelId1",
                table: "loanEmployees",
                column: "DashBoardViewModelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_loanEmployees_DashBoardViewModel_DashBoardViewModelId1",
                table: "loanEmployees",
                column: "DashBoardViewModelId1",
                principalTable: "DashBoardViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loanEmployees_DashBoardViewModel_DashBoardViewModelId1",
                table: "loanEmployees");

            migrationBuilder.DropIndex(
                name: "IX_loanEmployees_DashBoardViewModelId1",
                table: "loanEmployees");

            migrationBuilder.DropColumn(
                name: "TotalProfit",
                table: "tradeinformations");

            migrationBuilder.DropColumn(
                name: "TotlaLoss",
                table: "tradeinformations");

            migrationBuilder.DropColumn(
                name: "DashBoardViewModelId1",
                table: "loanEmployees");

            migrationBuilder.DropColumn(
                name: "LoanDate",
                table: "DashBoardViewModel");

            migrationBuilder.DropColumn(
                name: "TotalIntrest",
                table: "DashBoardViewModel");
        }
    }
}
