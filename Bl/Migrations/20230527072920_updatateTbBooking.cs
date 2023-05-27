using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class updatateTbBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbBookings_TbCustomers_CustomerID",
                table: "TbBookings");

            migrationBuilder.DropIndex(
                name: "IX_TbBookings_CustomerID",
                table: "TbBookings");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "TbBookings");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "TbCustomers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "TbCustomerCustomerID",
                table: "TbBookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbBookings_TbCustomerCustomerID",
                table: "TbBookings",
                column: "TbCustomerCustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbBookings_TbCustomers_TbCustomerCustomerID",
                table: "TbBookings",
                column: "TbCustomerCustomerID",
                principalTable: "TbCustomers",
                principalColumn: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbBookings_TbCustomers_TbCustomerCustomerID",
                table: "TbBookings");

            migrationBuilder.DropIndex(
                name: "IX_TbBookings_TbCustomerCustomerID",
                table: "TbBookings");

            migrationBuilder.DropColumn(
                name: "TbCustomerCustomerID",
                table: "TbBookings");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerPhone",
                table: "TbCustomers",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "TbBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbBookings_CustomerID",
                table: "TbBookings",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbBookings_TbCustomers_CustomerID",
                table: "TbBookings",
                column: "CustomerID",
                principalTable: "TbCustomers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
