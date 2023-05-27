using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class updatateTbBooking2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbBookings_TbServices_ServiceID",
                table: "TbBookings");

            migrationBuilder.DropIndex(
                name: "IX_TbBookings_ServiceID",
                table: "TbBookings");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "TbBookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "TbBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbBookings_ServiceID",
                table: "TbBookings",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbBookings_TbServices_ServiceID",
                table: "TbBookings",
                column: "ServiceID",
                principalTable: "TbServices",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
