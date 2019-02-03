using Microsoft.EntityFrameworkCore.Migrations;

namespace Komis.Migrations
{
    public partial class SamochodZmianaModelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JestwCentrali",
                table: "Samochody",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JestwCentrali",
                table: "Samochody");
        }
    }
}
