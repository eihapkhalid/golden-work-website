using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbAbouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutCompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutCompanyTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutFeature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutCompanyDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutCompanyAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutCompanyPhone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    AboutCompanyEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutCompanyLogo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutCompanyHistory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutCompanyValues = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutCompanyAchievements = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutCompletedProjects = table.Column<int>(type: "int", nullable: false),
                    AboutYearsExperience = table.Column<int>(type: "int", nullable: false),
                    AboutWorkingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutWorkingDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AboutCurrentState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAbouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "TbContacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactPhone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    ContactMessage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactCurrentState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbContacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerPhone = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerSatisfied = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerCurrentState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "TbNews",
                columns: table => new
                {
                    NewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NewsContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsCurrentState = table.Column<int>(type: "int", nullable: false),
                    NewsCurrentlyFeatured = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbNews", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "TbServices",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceCurrentlyFeatured = table.Column<int>(type: "int", nullable: false),
                    ServiceCurrentState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbServices", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "TbTechnicians",
                columns: table => new
                {
                    TechnicianID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnicianName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TechnicianExperience = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TechnicianQualification = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TechnicianImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TechnicianExpert = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    TechnicianSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsGetTechnicianSalary = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TechnicianCurrentlyFeatured = table.Column<int>(type: "int", nullable: false),
                    TechnicianCurrentState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbTechnicians", x => x.TechnicianID);
                });

            migrationBuilder.CreateTable(
                name: "TbUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCurrentState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsers", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "TbCustomerReviews",
                columns: table => new
                {
                    CustomerReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerReviewText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerReviewRating = table.Column<int>(type: "int", nullable: false),
                    CustomerReviewLogo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerReviewCurrentlyFeatured = table.Column<int>(type: "int", nullable: false),
                    CustomerReviewCurrentState = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCustomerReviews", x => x.CustomerReviewID);
                    table.ForeignKey(
                        name: "FK_TbCustomerReviews_TbCustomers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "TbCustomers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbBookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdateTimee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingCurrentState = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_TbBookings_TbCustomers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "TbCustomers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbBookings_TbServices_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "TbServices",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbBookings_CustomerID",
                table: "TbBookings",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_TbBookings_ServiceID",
                table: "TbBookings",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_TbCustomerReviews_CustomerID",
                table: "TbCustomerReviews",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbAbouts");

            migrationBuilder.DropTable(
                name: "TbBookings");

            migrationBuilder.DropTable(
                name: "TbContacts");

            migrationBuilder.DropTable(
                name: "TbCustomerReviews");

            migrationBuilder.DropTable(
                name: "TbNews");

            migrationBuilder.DropTable(
                name: "TbTechnicians");

            migrationBuilder.DropTable(
                name: "TbUsers");

            migrationBuilder.DropTable(
                name: "TbServices");

            migrationBuilder.DropTable(
                name: "TbCustomers");
        }
    }
}
