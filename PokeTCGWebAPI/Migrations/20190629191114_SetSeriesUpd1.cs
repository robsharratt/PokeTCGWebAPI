using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTCGWebAPI.Migrations
{
    public partial class SetSeriesUpd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_SetSeries_SetSeriesID",
                table: "Sets");

            migrationBuilder.AlterColumn<int>(
                name: "SetSeriesID",
                table: "Sets",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_SetSeries_SetSeriesID",
                table: "Sets",
                column: "SetSeriesID",
                principalTable: "SetSeries",
                principalColumn: "SetSeriesID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_SetSeries_SetSeriesID",
                table: "Sets");

            migrationBuilder.AlterColumn<int>(
                name: "SetSeriesID",
                table: "Sets",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_SetSeries_SetSeriesID",
                table: "Sets",
                column: "SetSeriesID",
                principalTable: "SetSeries",
                principalColumn: "SetSeriesID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
