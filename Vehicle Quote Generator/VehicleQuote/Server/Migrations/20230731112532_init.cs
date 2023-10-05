using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleQuote.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    username = table.Column<string>(nullable: false),
                    vehicletype = table.Column<string>(nullable: false),
                    vehicleage = table.Column<string>(nullable: false),
                    vehiclemake = table.Column<string>(nullable: false),
                    vehiclemodel = table.Column<string>(nullable: false),
                    vehiclecoverage = table.Column<string>(nullable: false),
                    formula = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
