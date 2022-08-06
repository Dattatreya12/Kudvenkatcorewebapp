using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class Changedthecolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "loanEmployees");

            migrationBuilder.AlterColumn<double>(
                name: "TotalIntrest",
                table: "loanEmployees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanDate",
                table: "loanEmployees",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "LoanUserName",
                table: "loanEmployees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanEmployeesId",
                table: "employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_LoanEmployeesId",
                table: "employees",
                column: "LoanEmployeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_loanEmployees_LoanEmployeesId",
                table: "employees",
                column: "LoanEmployeesId",
                principalTable: "loanEmployees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_loanEmployees_LoanEmployeesId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_LoanEmployeesId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "LoanUserName",
                table: "loanEmployees");

            migrationBuilder.DropColumn(
                name: "LoanEmployeesId",
                table: "employees");

            migrationBuilder.AlterColumn<int>(
                name: "TotalIntrest",
                table: "loanEmployees",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanDate",
                table: "loanEmployees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "loanEmployees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
