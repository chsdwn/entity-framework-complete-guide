﻿// <auto-generated />
using System;
using EFCompleteGuide.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCompleteGuide.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201007105751_AddManyToManyFluentAuthorAndFluentBook")]
    partial class AddManyToManyFluentAuthorAndFluentBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.HasKey("Author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookDetail_Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Book_Id");

                    b.HasIndex("BookDetail_Id")
                        .IsUnique();

                    b.HasIndex("Publisher_Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.BookAuthor", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Book_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Name")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CategoryName");

                    b.HasKey("Category_Id");

                    b.ToTable("tbl_Categories");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentAuthor", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.HasKey("Author_Id");

                    b.ToTable("FluentAuthors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBook", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FluentBookDetail_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FluentPublisher_Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Book_Id");

                    b.HasIndex("FluentBookDetail_Id")
                        .IsUnique();

                    b.HasIndex("FluentPublisher_Id");

                    b.ToTable("FluentBooks");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBookAuthor", b =>
                {
                    b.Property<int>("FluentAuthor_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FluentBook_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("FluentAuthor_Id", "FluentBook_Id");

                    b.HasIndex("FluentBook_Id");

                    b.ToTable("FluentBookAuthor");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("FluentBookDetails");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentPublisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Publisher_Id");

                    b.ToTable("FluentPublishers");
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

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Book", b =>
                {
                    b.HasOne("EFCompleteGuide.Model.Models.BookDetail", "BookDetail")
                        .WithOne("Book")
                        .HasForeignKey("EFCompleteGuide.Model.Models.Book", "BookDetail_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCompleteGuide.Model.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetail");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.BookAuthor", b =>
                {
                    b.HasOne("EFCompleteGuide.Model.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCompleteGuide.Model.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBook", b =>
                {
                    b.HasOne("EFCompleteGuide.Model.Models.FluentBookDetail", "FluentBookDetail")
                        .WithOne("FluentBook")
                        .HasForeignKey("EFCompleteGuide.Model.Models.FluentBook", "FluentBookDetail_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCompleteGuide.Model.Models.FluentPublisher", "FluentPublisher")
                        .WithMany("FluentBooks")
                        .HasForeignKey("FluentPublisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FluentBookDetail");

                    b.Navigation("FluentPublisher");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBookAuthor", b =>
                {
                    b.HasOne("EFCompleteGuide.Model.Models.FluentAuthor", "FluentAuthor")
                        .WithMany("FluentBookAuthors")
                        .HasForeignKey("FluentAuthor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCompleteGuide.Model.Models.FluentBook", "FluentBook")
                        .WithMany("FluentBookAuthors")
                        .HasForeignKey("FluentBook_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FluentAuthor");

                    b.Navigation("FluentBook");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.BookDetail", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentAuthor", b =>
                {
                    b.Navigation("FluentBookAuthors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBook", b =>
                {
                    b.Navigation("FluentBookAuthors");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentBookDetail", b =>
                {
                    b.Navigation("FluentBook");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.FluentPublisher", b =>
                {
                    b.Navigation("FluentBooks");
                });

            modelBuilder.Entity("EFCompleteGuide.Model.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
