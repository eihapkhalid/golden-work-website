using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class updateTbAbout_AboutImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutImageBig",
                table: "TbAbouts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "ssssssssss");

            migrationBuilder.AddColumn<string>(
                name: "AboutImageSmal",
                table: "TbAbouts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "ssssssssssss");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutImageBig",
                table: "TbAbouts");

            migrationBuilder.DropColumn(
                name: "AboutImageSmal",
                table: "TbAbouts");
        }
    }
}
