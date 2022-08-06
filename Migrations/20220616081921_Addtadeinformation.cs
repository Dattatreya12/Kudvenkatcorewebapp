using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kudvenkatcorewebapp.Migrations
{
    public partial class Addtadeinformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tradeinformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stockname = table.Column<string>(nullable: true),
                    Stockbuykprice = table.Column<double>(nullable: false),
                    Stocksellprice = table.Column<double>(nullable: false),
                    Stocktotalshares = table.Column<int>(nullable: false),
                    Stockpurchaseddate = table.Column<DateTime>(nullable: false),
                    Stockselldate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<int>(nullable: false),
                    brokerid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradeinformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tradeinformations_brokers_brokerid",
                        column: x => x.brokerid,
                        principalTable: "brokers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tradeinformations_brokerid",
                table: "tradeinformations",
                column: "brokerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tradeinformations");
        }
    }
}
