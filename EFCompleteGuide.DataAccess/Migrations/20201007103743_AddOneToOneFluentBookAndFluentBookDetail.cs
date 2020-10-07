using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCompleteGuide.DataAccess.Migrations
{
    public partial class AddOneToOneFluentBookAndFluentBookDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBookDetails_Books_Book_Id",
                table: "FluentBookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_BookDetails_BookDetail_Id1",
                table: "FluentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_Publishers_Publisher_Id1",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_BookDetail_Id1",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_Publisher_Id1",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBookDetails_Book_Id",
                table: "FluentBookDetails");

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
                name: "BookDetail_Id1",
                table: "FluentBooks");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "FluentBooks");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "FluentBookDetails");

            migrationBuilder.DropColumn(
                name: "FluentPublisherPublisher_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FluentAuthorAuthor_Id",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "FluentBookBook_Id",
                table: "BookAuthors");

            migrationBuilder.RenameColumn(
                name: "Publisher_Id1",
                table: "FluentBooks",
                newName: "FluentBookDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_FluentBookDetail_Id",
                table: "FluentBooks",
                column: "FluentBookDetail_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_FluentBookDetail_Id",
                table: "FluentBooks",
                column: "FluentBookDetail_Id",
                principalTable: "FluentBookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_FluentBookDetail_Id",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_FluentBookDetail_Id",
                table: "FluentBooks");

            migrationBuilder.RenameColumn(
                name: "FluentBookDetail_Id",
                table: "FluentBooks",
                newName: "Publisher_Id1");

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_Id1",
                table: "FluentBooks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "FluentBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "FluentBookDetails",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_BookDetail_Id1",
                table: "FluentBooks",
                column: "BookDetail_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_Publisher_Id1",
                table: "FluentBooks",
                column: "Publisher_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_FluentBookDetails_Book_Id",
                table: "FluentBookDetails",
                column: "Book_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBookDetails_Books_Book_Id",
                table: "FluentBookDetails",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_BookDetails_BookDetail_Id1",
                table: "FluentBooks",
                column: "BookDetail_Id1",
                principalTable: "BookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_Publishers_Publisher_Id1",
                table: "FluentBooks",
                column: "Publisher_Id1",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
