using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class updateinprofitloss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IncomeLoss",
                table: "AddProfitLosses",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "IncomeLoss",
                table: "AddProfitLosses",
                type: "real",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
