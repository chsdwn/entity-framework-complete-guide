using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCompleteGuide.DataAccess.Migrations
{
    public partial class AddOneToManyFluentBookAndFluentPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_FluentBookDetail_Id",
                table: "FluentBooks");

            migrationBuilder.RenameColumn(
                name: "BookDetail_Id",
                table: "FluentBooks",
                newName: "FluentPublisher_Id");

            migrationBuilder.AlterColumn<int>(
                name: "FluentBookDetail_Id",
                table: "FluentBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FluentBooks_FluentPublisher_Id",
                table: "FluentBooks",
                column: "FluentPublisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_FluentBookDetail_Id",
                table: "FluentBooks",
                column: "FluentBookDetail_Id",
                principalTable: "FluentBookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentPublishers_FluentPublisher_Id",
                table: "FluentBooks",
                column: "FluentPublisher_Id",
                principalTable: "FluentPublishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_FluentBookDetail_Id",
                table: "FluentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentPublishers_FluentPublisher_Id",
                table: "FluentBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentBooks_FluentPublisher_Id",
                table: "FluentBooks");

            migrationBuilder.RenameColumn(
                name: "FluentPublisher_Id",
                table: "FluentBooks",
                newName: "BookDetail_Id");

            migrationBuilder.AlterColumn<int>(
                name: "FluentBookDetail_Id",
                table: "FluentBooks",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_FluentBookDetail_Id",
                table: "FluentBooks",
                column: "FluentBookDetail_Id",
                principalTable: "FluentBookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
