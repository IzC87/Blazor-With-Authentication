using Microsoft.EntityFrameworkCore.Migrations;

namespace Medieval.Server.Migrations
{
    public partial class CorrectSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Resources_ResourcessId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "ResourcessId",
                table: "Games",
                newName: "ResourcesId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_ResourcessId",
                table: "Games",
                newName: "IX_Games_ResourcesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Resources_ResourcesId",
                table: "Games",
                column: "ResourcesId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Resources_ResourcesId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "ResourcesId",
                table: "Games",
                newName: "ResourcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_ResourcesId",
                table: "Games",
                newName: "IX_Games_ResourcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Resources_ResourcessId",
                table: "Games",
                column: "ResourcessId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
