using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamCar472.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class removedappUsrs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleID",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AppUsers_AppUserID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsers_AppRoleID",
                table: "AppUser",
                newName: "IX_AppUser_AppRoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AppRoles_AppRoleID",
                table: "AppUser",
                column: "AppRoleID",
                principalTable: "AppRoles",
                principalColumn: "AppRoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AppUser_AppUserID",
                table: "Blogs",
                column: "AppUserID",
                principalTable: "AppUser",
                principalColumn: "AppUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AppRoles_AppRoleID",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AppUser_AppUserID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_AppRoleID",
                table: "AppUsers",
                newName: "IX_AppUsers_AppRoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppRoles_AppRoleID",
                table: "AppUsers",
                column: "AppRoleID",
                principalTable: "AppRoles",
                principalColumn: "AppRoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AppUsers_AppUserID",
                table: "Blogs",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "AppUserID");
        }
    }
}
