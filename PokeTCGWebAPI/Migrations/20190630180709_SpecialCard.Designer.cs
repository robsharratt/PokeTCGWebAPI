﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PokeTCGWebAPI.Models;

namespace PokeTCGWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190630180709_SpecialCard")]
    partial class SpecialCard
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PokeTCGWebAPI.Models.Card", b =>
                {
                    b.Property<int>("CardID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<int>("CardCatID");

                    b.Property<string>("CardImageHiURL");

                    b.Property<string>("CardImageURL");

                    b.Property<string>("CardName");

                    b.Property<string>("CardNum");

                    b.Property<string>("CardRarity");

                    b.Property<int>("CardTypeID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("SetID");

                    b.Property<DateTime>("SetReleaseDate");

                    b.HasKey("CardID");

                    b.HasIndex("CardCatID");

                    b.HasIndex("CardTypeID");

                    b.HasIndex("SetID");

                    b.ToTable("Cards");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Card");
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.CardCat", b =>
                {
                    b.Property<int>("CardCatID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardCatName");

                    b.Property<DateTime>("LastUpdateDate");

                    b.HasKey("CardCatID");

                    b.ToTable("CardCats");
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.CardType", b =>
                {
                    b.Property<int>("CardTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardTypeName");

                    b.Property<DateTime>("LastUpdateDate");

                    b.HasKey("CardTypeID");

                    b.ToTable("CardTypes");
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.Set", b =>
                {
                    b.Property<int>("SetID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("SetCode");

                    b.Property<bool>("SetExpanded");

                    b.Property<string>("SetLogoURL");

                    b.Property<string>("SetName");

                    b.Property<string>("SetPTCGOCode");

                    b.Property<DateTime>("SetReleaseDate");

                    b.Property<int?>("SetSeriesID");

                    b.Property<bool>("SetStandard");

                    b.Property<string>("SetSymbolURL");

                    b.Property<int>("SetTotalCards");

                    b.HasKey("SetID");

                    b.HasIndex("SetSeriesID");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.SetSeries", b =>
                {
                    b.Property<int>("SetSeriesID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("SetSeriesName");

                    b.HasKey("SetSeriesID");

                    b.ToTable("SetSeries");
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.SpecialCard", b =>
                {
                    b.HasBaseType("PokeTCGWebAPI.Models.Card");

                    b.HasDiscriminator().HasValue("SpecialCard");
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.Card", b =>
                {
                    b.HasOne("PokeTCGWebAPI.Models.CardCat", "CardCat")
                        .WithMany("Cards")
                        .HasForeignKey("CardCatID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PokeTCGWebAPI.Models.CardType", "CardType")
                        .WithMany("Cards")
                        .HasForeignKey("CardTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PokeTCGWebAPI.Models.Set", "Set")
                        .WithMany("Cards")
                        .HasForeignKey("SetID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PokeTCGWebAPI.Models.Set", b =>
                {
                    b.HasOne("PokeTCGWebAPI.Models.SetSeries", "SetSeries")
                        .WithMany("Sets")
                        .HasForeignKey("SetSeriesID");
                });
#pragma warning restore 612, 618
        }
    }
}
