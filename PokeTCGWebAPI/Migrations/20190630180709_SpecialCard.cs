using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTCGWebAPI.Migrations
{
    public partial class SpecialCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Cards",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Cards");
        }
    }
}
