using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCompleteGuide.DataAccess.Migrations
{
    public partial class AddFluentAuthorsFluentBooksFluentPublishersTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FluentPublisherPublisher_Id",
                table: "Books",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FluentAuthorAuthor_Id",
                table: "BookAuthors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FluentBookBook_Id",
                table: "BookAuthors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FluentAuthors",
                columns: table => new
                {
                    Author_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAuthors", x => x.Author_Id);
                });

            migrationBuilder.CreateTable(
                name: "FluentBooks",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    BookDetail_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    BookDetail_Id1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Publisher_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Publisher_Id1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentBooks", x => x.Book_Id);
                    table.ForeignKey(
                        name: "FK_FluentBooks_BookDetails_BookDetail_Id1",
                        column: x => x.BookDetail_Id1,
                        principalTable: "BookDetails",
                        principalColumn: "BookDetail_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FluentBooks_Publishers_Publisher_Id1",
                        column: x => x.Publisher_Id1,
                        principalTable: "Publishers",
                        principalColumn: "Publisher_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FluentPublishers",
                columns: table => new
                {
                    Publisher_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentPublishers", x => x.Publisher_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_FluentPublisherPublisher_Id",
                table: "Books",
                column: "FluentPublisherPublisher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_FluentAuthorAuthor_Id",
                table: "BookAuthors",
                column: "FluentAuthorAuthor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_FluentBookBook_Id",
                table: "BookAuthors",
                column: "FluentBookBook_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_BookDetail_Id1",
                table: "FluentBooks",
                column: "BookDetail_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_Publisher_Id1",
                table: "FluentBooks",
                column: "Publisher_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_FluentAuthors_FluentAuthorAuthor_Id",
                table: "BookAuthors",
                column: "FluentAuthorAuthor_Id",
                principalTable: "FluentAuthors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_FluentBooks_FluentBookBook_Id",
                table: "BookAuthors",
                column: "FluentBookBook_Id",
                principalTable: "FluentBooks",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_FluentPublishers_FluentPublisherPublisher_Id",
                table: "Books",
                column: "FluentPublisherPublisher_Id",
                principalTable: "FluentPublishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_FluentAuthors_FluentAuthorAuthor_Id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_FluentBooks_FluentBookBook_Id",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_FluentPublishers_FluentPublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropTable(
                name: "FluentAuthors");

            migrationBuilder.DropTable(
                name: "FluentBooks");

            migrationBuilder.DropTable(
                name: "FluentPublishers");

            migrationBuilder.DropIndex(
                name: "IX_Books_FluentPublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_FluentAuthorAuthor_Id",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_FluentBookBook_Id",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "FluentPublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FluentAuthorAuthor_Id",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "FluentBookBook_Id",
                table: "BookAuthors");
        }
    }
}
