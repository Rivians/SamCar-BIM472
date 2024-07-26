using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamCar472.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Auhtors_AuthorID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auhtors",
                table: "Auhtors");

            migrationBuilder.RenameTable(
                name: "Auhtors",
                newName: "Auhtorss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auhtorss",
                table: "Auhtorss",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Auhtorss_AuthorID",
                table: "Blogs",
                column: "AuthorID",
                principalTable: "Auhtorss",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Auhtorss_AuthorID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auhtorss",
                table: "Auhtorss");

            migrationBuilder.RenameTable(
                name: "Auhtorss",
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
    }
}
