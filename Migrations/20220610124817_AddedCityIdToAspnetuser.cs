using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class AddedCityIdToAspnetuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityMasterID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CityMasters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    Active = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMasters", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityMasterID",
                table: "AspNetUsers",
                column: "CityMasterID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CityMasters_CityMasterID",
                table: "AspNetUsers",
                column: "CityMasterID",
                principalTable: "CityMasters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CityMasters_CityMasterID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CityMasters");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CityMasterID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CityMasterID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
