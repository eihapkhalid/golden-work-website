using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class AddTbMainAd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbMainAds",
                columns: table => new
                {
                    mainAdID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainAdImageBig = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MainAdImageSmall = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MainAdCurrentState = table.Column<int>(type: "int", nullable: false),
                    MainAdCurrentlyFeatured = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbMainAds", x => x.mainAdID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbMainAds");
        }
    }
}
