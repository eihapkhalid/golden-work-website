using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTbBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutImageBig",
                table: "TbAbouts");

            migrationBuilder.DropColumn(
                name: "AboutImageSmal",
                table: "TbAbouts");

            migrationBuilder.AddColumn<string>(
                name: "BookingEmail",
                table: "TbBookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BookingFirstName",
                table: "TbBookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BookingServiceName",
                table: "TbBookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingEmail",
                table: "TbBookings");

            migrationBuilder.DropColumn(
                name: "BookingFirstName",
                table: "TbBookings");

            migrationBuilder.DropColumn(
                name: "BookingServiceName",
                table: "TbBookings");

            migrationBuilder.AddColumn<string>(
                name: "AboutImageBig",
                table: "TbAbouts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutImageSmal",
                table: "TbAbouts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
