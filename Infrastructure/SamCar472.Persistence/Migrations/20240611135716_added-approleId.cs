using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamCar472.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedapproleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AppUsers");
        }
    }
}
