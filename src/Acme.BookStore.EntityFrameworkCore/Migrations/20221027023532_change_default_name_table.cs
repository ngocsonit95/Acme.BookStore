using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    public partial class change_default_name_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBooks_tblAuthors_AuthorId",
                table: "tblBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblBooks",
                table: "tblBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblAuthors",
                table: "tblAuthors");

            migrationBuilder.RenameTable(
                name: "tblBooks",
                newName: "AppBooks");

            migrationBuilder.RenameTable(
                name: "tblAuthors",
                newName: "AppAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_tblBooks_AuthorId",
                table: "AppBooks",
                newName: "IX_AppBooks_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_tblAuthors_Name",
                table: "AppAuthors",
                newName: "IX_AppAuthors_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppBooks",
                table: "AppBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAuthors",
                table: "AppAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppBooks_AppAuthors_AuthorId",
                table: "AppBooks",
                column: "AuthorId",
                principalTable: "AppAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBooks_AppAuthors_AuthorId",
                table: "AppBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppBooks",
                table: "AppBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAuthors",
                table: "AppAuthors");

            migrationBuilder.RenameTable(
                name: "AppBooks",
                newName: "tblBooks");

            migrationBuilder.RenameTable(
                name: "AppAuthors",
                newName: "tblAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_AppBooks_AuthorId",
                table: "tblBooks",
                newName: "IX_tblBooks_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_AppAuthors_Name",
                table: "tblAuthors",
                newName: "IX_tblAuthors_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblBooks",
                table: "tblBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblAuthors",
                table: "tblAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBooks_tblAuthors_AuthorId",
                table: "tblBooks",
                column: "AuthorId",
                principalTable: "tblAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
