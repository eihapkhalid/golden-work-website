﻿// <auto-generated />
using System;
using Bl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bl.Migrations
{
    [DbContext(typeof(GoldenDbContext))]
    [Migration("20230526172210_AddTbMainAd")]
    partial class AddTbMainAd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domains.TbAbout", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutID"));

                    b.Property<string>("AboutCompanyAchievements")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AboutCompanyAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AboutCompanyDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AboutCompanyEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AboutCompanyHistory")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AboutCompanyLogo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AboutCompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("AboutCompanyPhone")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("AboutCompanyTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AboutCompanyValues")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AboutCompletedProjects")
                        .HasColumnType("int");

                    b.Property<int>("AboutCurrentState")
                        .HasColumnType("int");

                    b.Property<string>("AboutFeature")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AboutImageBig")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AboutImageSmal")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AboutWorkingDays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutWorkingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AboutYearsExperience")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AboutID");

                    b.ToTable("TbAbouts");
                });

            modelBuilder.Entity("Domains.TbBooking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("BookingCurrentState")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookingEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookingStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTimee")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ServiceID");

                    b.ToTable("TbBookings");
                });

            modelBuilder.Entity("Domains.TbContact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"));

                    b.Property<int>("ContactCurrentState")
                        .HasColumnType("int");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactMessage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ContactPhone")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ContactID");

                    b.ToTable("TbContacts");
                });

            modelBuilder.Entity("Domains.TbCustomer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CustomerCurrentState")
                        .HasColumnType("int");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CustomerPhone")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("CustomerSatisfied")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerID");

                    b.ToTable("TbCustomers");
                });

            modelBuilder.Entity("Domains.TbCustomerReview", b =>
                {
                    b.Property<int>("CustomerReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerReviewID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerReviewCurrentState")
                        .HasColumnType("int");

                    b.Property<int>("CustomerReviewCurrentlyFeatured")
                        .HasColumnType("int");

                    b.Property<string>("CustomerReviewLogo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CustomerReviewRating")
                        .HasColumnType("int");

                    b.Property<string>("CustomerReviewText")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerReviewID");

                    b.HasIndex("CustomerID");

                    b.ToTable("TbCustomerReviews");
                });

            modelBuilder.Entity("Domains.TbMainAd", b =>
                {
                    b.Property<int>("mainAdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("mainAdID"));

                    b.Property<int>("MainAdCurrentState")
                        .HasColumnType("int");

                    b.Property<int>("MainAdCurrentlyFeatured")
                        .HasColumnType("int");

                    b.Property<string>("MainAdImageBig")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MainAdImageSmall")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("mainAdID");

                    b.ToTable("TbMainAds");
                });

            modelBuilder.Entity("Domains.TbNews", b =>
                {
                    b.Property<int>("NewsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsID"));

                    b.Property<string>("NewsContent")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("NewsCurrentState")
                        .HasColumnType("int");

                    b.Property<int>("NewsCurrentlyFeatured")
                        .HasColumnType("int");

                    b.Property<DateTime>("NewsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("NewsID");

                    b.ToTable("TbNews");
                });

            modelBuilder.Entity("Domains.TbService", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<int>("ServiceCurrentState")
                        .HasColumnType("int");

                    b.Property<int>("ServiceCurrentlyFeatured")
                        .HasColumnType("int");

                    b.Property<string>("ServiceDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ServiceImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ServicePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ServiceID");

                    b.ToTable("TbServices");
                });

            modelBuilder.Entity("Domains.TbTechnician", b =>
                {
                    b.Property<int>("TechnicianID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TechnicianID"));

                    b.Property<bool>("IsGetTechnicianSalary")
                        .HasColumnType("bit");

                    b.Property<int>("TechnicianCurrentState")
                        .HasColumnType("int");

                    b.Property<int>("TechnicianCurrentlyFeatured")
                        .HasColumnType("int");

                    b.Property<string>("TechnicianExperience")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TechnicianExpert")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<string>("TechnicianImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TechnicianName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TechnicianQualification")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("TechnicianSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("TechnicianID");

                    b.ToTable("TbTechnicians");
                });

            modelBuilder.Entity("Domains.TbUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("UserCreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserCurrentState")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UserUpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID");

                    b.ToTable("TbUsers");
                });

            modelBuilder.Entity("Domains.TbBooking", b =>
                {
                    b.HasOne("Domains.TbCustomer", "_TbCustomer")
                        .WithMany("_TbBookings")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.TbService", "_TbService")
                        .WithMany("_TbBookings")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_TbCustomer");

                    b.Navigation("_TbService");
                });

            modelBuilder.Entity("Domains.TbCustomerReview", b =>
                {
                    b.HasOne("Domains.TbCustomer", "_TbCustomer")
                        .WithMany("_TbCustomerReviews")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_TbCustomer");
                });

            modelBuilder.Entity("Domains.TbCustomer", b =>
                {
                    b.Navigation("_TbBookings");

                    b.Navigation("_TbCustomerReviews");
                });

            modelBuilder.Entity("Domains.TbService", b =>
                {
                    b.Navigation("_TbBookings");
                });
#pragma warning restore 612, 618
        }
    }
}
