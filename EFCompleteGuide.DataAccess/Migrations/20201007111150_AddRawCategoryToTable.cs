using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCompleteGuide.DataAccess.Migrations
{
    public partial class AddRawCategoryToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO tbl_Categories VALUES(1, 'Crime')");
            migrationBuilder.Sql("INSERT INTO tbl_Categories VALUES(2, 'Fantasy')");
            migrationBuilder.Sql("INSERT INTO tbl_Categories VALUES(3, 'Mistery')");
            migrationBuilder.Sql("INSERT INTO tbl_Categories VALUES(4, 'Thriller')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
