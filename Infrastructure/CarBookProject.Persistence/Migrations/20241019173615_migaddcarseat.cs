using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migaddcarseat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BannerId",
                table: "Banners",
                newName: "BannerID");

            migrationBuilder.AddColumn<byte>(
                name: "Seat",
                table: "Cars",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seat",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "BannerID",
                table: "Banners",
                newName: "BannerId");
        }
    }
}
