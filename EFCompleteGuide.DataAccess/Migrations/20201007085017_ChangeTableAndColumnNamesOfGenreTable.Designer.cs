﻿// <auto-generated />
using EFCompleteGuide.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCompleteGuide.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201007085017_ChangeTableAndColumnNamesOfGenreTable")]
    partial class ChangeTableAndColumnNamesOfGenreTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GenreName")
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("GenreId");

                    b.ToTable("tb_Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
