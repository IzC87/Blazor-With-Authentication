using Microsoft.EntityFrameworkCore.Migrations;

namespace Medieval.Server.Migrations
{
    public partial class RenamedUserNameToUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Games",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Games",
                newName: "UserName");
        }
    }
}
