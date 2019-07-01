using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTCGWebAPI.Migrations
{
    public partial class Cards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SetID",
                table: "Cards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_SetID",
                table: "Cards",
                column: "SetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards",
                column: "SetID",
                principalTable: "Sets",
                principalColumn: "SetID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_SetID",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardName",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SetID",
                table: "Cards");
        }
    }
}
