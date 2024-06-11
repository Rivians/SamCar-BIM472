using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamCar472.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AppUsers_AppUserID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AppUserID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Blogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AppUserID",
                table: "Blogs",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AppUsers_AppUserID",
                table: "Blogs",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID");
        }
    }
}
