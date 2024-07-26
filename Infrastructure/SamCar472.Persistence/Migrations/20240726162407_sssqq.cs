using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamCar472.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sssqq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Author_AuthorID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Auhtors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auhtors",
                table: "Auhtors",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Auhtors_AuthorID",
                table: "Blogs",
                column: "AuthorID",
                principalTable: "Auhtors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Auhtors_AuthorID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auhtors",
                table: "Auhtors");

            migrationBuilder.RenameTable(
                name: "Auhtors",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Author_AuthorID",
                table: "Blogs",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
