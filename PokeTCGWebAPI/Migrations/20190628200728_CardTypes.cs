using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PokeTCGWebAPI.Migrations
{
    public partial class CardTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "SetSeries",
                table: "Sets",
                newName: "SetPTCGOCode");

            migrationBuilder.AddColumn<int>(
                name: "SetSeriesID",
                table: "Sets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SetTotalCards",
                table: "Sets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SetID",
                table: "Cards",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardCatID",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CardImageHiURL",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardImageURL",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNum",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardRarity",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardTypeID",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Cards",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SetReleaseDate",
                table: "Cards",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CardCats",
                columns: table => new
                {
                    CardCatID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CardCatName = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCats", x => x.CardCatID);
                });

            migrationBuilder.CreateTable(
                name: "SetSeries",
                columns: table => new
                {
                    SetSeriesID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SetSeriesName = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetSeries", x => x.SetSeriesID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sets_SetSeriesID",
                table: "Sets",
                column: "SetSeriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardCatID",
                table: "Cards",
                column: "CardCatID");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardTypeID",
                table: "Cards",
                column: "CardTypeID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_SetSeries_SetSeriesID",
                table: "Sets",
                column: "SetSeriesID",
                principalTable: "SetSeries",
                principalColumn: "SetSeriesID",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DropForeignKey(
                name: "FK_Sets_SetSeries_SetSeriesID",
                table: "Sets");

            migrationBuilder.DropTable(
                name: "CardCats");

            migrationBuilder.DropTable(
                name: "SetSeries");

            migrationBuilder.DropIndex(
                name: "IX_Sets_SetSeriesID",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CardCatID",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CardTypeID",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SetSeriesID",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "SetTotalCards",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardCatID",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardImageHiURL",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardImageURL",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardNum",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardRarity",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardTypeID",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SetReleaseDate",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "SetPTCGOCode",
                table: "Sets",
                newName: "SetSeries");

            migrationBuilder.AlterColumn<int>(
                name: "SetID",
                table: "Cards",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sets_SetID",
                table: "Cards",
                column: "SetID",
                principalTable: "Sets",
                principalColumn: "SetID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
