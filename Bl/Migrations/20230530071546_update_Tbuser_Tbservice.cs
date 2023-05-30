using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class update_Tbuser_Tbservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "TbServices",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_TbServices_UserID",
                table: "TbServices",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbServices_TbUsers_UserID",
                table: "TbServices",
                column: "UserID",
                principalTable: "TbUsers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbServices_TbUsers_UserID",
                table: "TbServices");

            migrationBuilder.DropIndex(
                name: "IX_TbServices_UserID",
                table: "TbServices");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "TbServices");
        }
    }
}
