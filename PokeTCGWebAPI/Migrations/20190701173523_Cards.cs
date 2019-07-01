using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTCGWebAPI.Migrations
{
    public partial class Cards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardCats_CardCatID",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardTypes_CardTypeID",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "SetID",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CardTypeID",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CardCatID",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardCats_CardCatID",
                table: "Cards",
                column: "CardCatID",
                principalTable: "CardCats",
                principalColumn: "CardCatID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardTypes_CardTypeID",
                table: "Cards",
                column: "CardTypeID",
                principalTable: "CardTypes",
                principalColumn: "CardTypeID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Cards_CardCats_CardCatID",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardTypes_CardTypeID",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "SetID",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardTypeID",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardCatID",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardCats_CardCatID",
                table: "Cards",
                column: "CardCatID",
                principalTable: "CardCats",
                principalColumn: "CardCatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardTypes_CardTypeID",
                table: "Cards",
                column: "CardTypeID",
                principalTable: "CardTypes",
                principalColumn: "CardTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards",
                column: "SetID",
                principalTable: "Sets",
                principalColumn: "SetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
