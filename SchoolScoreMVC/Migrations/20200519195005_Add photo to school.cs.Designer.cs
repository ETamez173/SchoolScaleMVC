﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolScoreMVC.Data;

namespace SchoolScoreMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200519195005_Add photo to school.cs")]
    partial class Addphototoschoolcs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.Degree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("EarningAvg")
                        .HasColumnType("float");

                    b.Property<double>("EarningHigh")
                        .HasColumnType("float");

                    b.Property<double>("EarningLow")
                        .HasColumnType("float");

                    b.Property<string>("EducationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Degree");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EarningAvg = 94352.0,
                            EarningHigh = 103213.0,
                            EarningLow = 73721.0,
                            EducationName = "Electical Engineer"
                        },
                        new
                        {
                            Id = 2,
                            EarningAvg = 87235.0,
                            EarningHigh = 92453.0,
                            EarningLow = 79440.0,
                            EducationName = "Chemical Engineer"
                        },
                        new
                        {
                            Id = 3,
                            EarningAvg = 58340.0,
                            EarningHigh = 73431.0,
                            EarningLow = 48301.0,
                            EducationName = "Registered Nurse"
                        },
                        new
                        {
                            Id = 4,
                            EarningAvg = 94301.0,
                            EarningHigh = 106011.0,
                            EarningLow = 78704.0,
                            EducationName = "Computer Science"
                        },
                        new
                        {
                            Id = 5,
                            EarningAvg = 32476.0,
                            EarningHigh = 53010.0,
                            EarningLow = 24045.0,
                            EducationName = "Liberal Arts"
                        },
                        new
                        {
                            Id = 6,
                            EarningAvg = 91402.0,
                            EarningHigh = 105910.0,
                            EarningLow = 78904.0,
                            EducationName = "Full Stack Software Developer"
                        },
                        new
                        {
                            Id = 7,
                            EarningAvg = 90401.0,
                            EarningHigh = 104201.0,
                            EarningLow = 77801.0,
                            EducationName = "Front-End Web Designer Developer"
                        },
                        new
                        {
                            Id = 8,
                            EarningAvg = 98704.0,
                            EarningHigh = 115230.0,
                            EarningLow = 83012.0,
                            EducationName = "Data Science"
                        },
                        new
                        {
                            Id = 9,
                            EarningAvg = 94431.0,
                            EarningHigh = 104878.0,
                            EarningLow = 82401.0,
                            EducationName = "Data Analytics"
                        });
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.DegreeSchool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AnnualCost")
                        .HasColumnType("float");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int>("StudyYears")
                        .HasColumnType("int");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DegreeId");

                    b.HasIndex("SchoolId");

                    b.ToTable("DegreeSchool");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnualCost = 12500.0,
                            DegreeId = 1,
                            SchoolId = 1,
                            StudyYears = 4,
                            TotalCost = 50000.0
                        },
                        new
                        {
                            Id = 2,
                            AnnualCost = 25000.0,
                            DegreeId = 1,
                            SchoolId = 2,
                            StudyYears = 4,
                            TotalCost = 100000.0
                        },
                        new
                        {
                            Id = 3,
                            AnnualCost = 25000.0,
                            DegreeId = 1,
                            SchoolId = 3,
                            StudyYears = 4,
                            TotalCost = 100000.0
                        },
                        new
                        {
                            Id = 4,
                            AnnualCost = 20000.0,
                            DegreeId = 1,
                            SchoolId = 4,
                            StudyYears = 4,
                            TotalCost = 80000.0
                        },
                        new
                        {
                            Id = 5,
                            AnnualCost = 12000.0,
                            DegreeId = 1,
                            SchoolId = 5,
                            StudyYears = 4,
                            TotalCost = 48000.0
                        },
                        new
                        {
                            Id = 6,
                            AnnualCost = 8000.0,
                            DegreeId = 1,
                            SchoolId = 6,
                            StudyYears = 4,
                            TotalCost = 32000.0
                        },
                        new
                        {
                            Id = 7,
                            AnnualCost = 10000.0,
                            DegreeId = 1,
                            SchoolId = 7,
                            StudyYears = 4,
                            TotalCost = 40000.0
                        },
                        new
                        {
                            Id = 8,
                            AnnualCost = 6500.0,
                            DegreeId = 1,
                            SchoolId = 8,
                            StudyYears = 4,
                            TotalCost = 26000.0
                        },
                        new
                        {
                            Id = 9,
                            AnnualCost = 1200.0,
                            DegreeId = 1,
                            SchoolId = 10,
                            StudyYears = 4,
                            TotalCost = 4800.0
                        },
                        new
                        {
                            Id = 10,
                            AnnualCost = 11250.0,
                            DegreeId = 2,
                            SchoolId = 1,
                            StudyYears = 4,
                            TotalCost = 45000.0
                        },
                        new
                        {
                            Id = 11,
                            AnnualCost = 13000.0,
                            DegreeId = 2,
                            SchoolId = 2,
                            StudyYears = 4,
                            TotalCost = 52000.0
                        },
                        new
                        {
                            Id = 12,
                            AnnualCost = 22000.0,
                            DegreeId = 2,
                            SchoolId = 4,
                            StudyYears = 4,
                            TotalCost = 88000.0
                        },
                        new
                        {
                            Id = 13,
                            AnnualCost = 21000.0,
                            DegreeId = 2,
                            SchoolId = 5,
                            StudyYears = 4,
                            TotalCost = 84000.0
                        },
                        new
                        {
                            Id = 14,
                            AnnualCost = 10500.0,
                            DegreeId = 2,
                            SchoolId = 7,
                            StudyYears = 4,
                            TotalCost = 42000.0
                        },
                        new
                        {
                            Id = 15,
                            AnnualCost = 1200.0,
                            DegreeId = 2,
                            SchoolId = 10,
                            StudyYears = 4,
                            TotalCost = 4800.0
                        },
                        new
                        {
                            Id = 16,
                            AnnualCost = 8500.0,
                            DegreeId = 5,
                            SchoolId = 1,
                            StudyYears = 4,
                            TotalCost = 34000.0
                        },
                        new
                        {
                            Id = 17,
                            AnnualCost = 15000.0,
                            DegreeId = 5,
                            SchoolId = 4,
                            StudyYears = 4,
                            TotalCost = 60000.0
                        },
                        new
                        {
                            Id = 18,
                            AnnualCost = 9500.0,
                            DegreeId = 3,
                            SchoolId = 1,
                            StudyYears = 4,
                            TotalCost = 38000.0
                        },
                        new
                        {
                            Id = 19,
                            AnnualCost = 13000.0,
                            DegreeId = 3,
                            SchoolId = 3,
                            StudyYears = 4,
                            TotalCost = 52000.0
                        },
                        new
                        {
                            Id = 20,
                            AnnualCost = 20000.0,
                            DegreeId = 3,
                            SchoolId = 4,
                            StudyYears = 4,
                            TotalCost = 80000.0
                        },
                        new
                        {
                            Id = 21,
                            AnnualCost = 16000.0,
                            DegreeId = 3,
                            SchoolId = 5,
                            StudyYears = 4,
                            TotalCost = 64000.0
                        },
                        new
                        {
                            Id = 22,
                            AnnualCost = 7500.0,
                            DegreeId = 3,
                            SchoolId = 6,
                            StudyYears = 4,
                            TotalCost = 30000.0
                        },
                        new
                        {
                            Id = 23,
                            AnnualCost = 9000.0,
                            DegreeId = 3,
                            SchoolId = 7,
                            StudyYears = 4,
                            TotalCost = 36000.0
                        },
                        new
                        {
                            Id = 24,
                            AnnualCost = 7000.0,
                            DegreeId = 3,
                            SchoolId = 8,
                            StudyYears = 4,
                            TotalCost = 28000.0
                        },
                        new
                        {
                            Id = 25,
                            AnnualCost = 800.0,
                            DegreeId = 3,
                            SchoolId = 10,
                            StudyYears = 4,
                            TotalCost = 3200.0
                        },
                        new
                        {
                            Id = 26,
                            AnnualCost = 10000.0,
                            DegreeId = 4,
                            SchoolId = 1,
                            StudyYears = 4,
                            TotalCost = 40000.0
                        },
                        new
                        {
                            Id = 27,
                            AnnualCost = 10000.0,
                            DegreeId = 4,
                            SchoolId = 2,
                            StudyYears = 4,
                            TotalCost = 40000.0
                        },
                        new
                        {
                            Id = 28,
                            AnnualCost = 16000.0,
                            DegreeId = 4,
                            SchoolId = 3,
                            StudyYears = 4,
                            TotalCost = 64000.0
                        },
                        new
                        {
                            Id = 29,
                            AnnualCost = 21000.0,
                            DegreeId = 4,
                            SchoolId = 4,
                            StudyYears = 4,
                            TotalCost = 84000.0
                        },
                        new
                        {
                            Id = 30,
                            AnnualCost = 20000.0,
                            DegreeId = 4,
                            SchoolId = 5,
                            StudyYears = 4,
                            TotalCost = 80000.0
                        },
                        new
                        {
                            Id = 31,
                            AnnualCost = 9000.0,
                            DegreeId = 4,
                            SchoolId = 6,
                            StudyYears = 4,
                            TotalCost = 36000.0
                        },
                        new
                        {
                            Id = 32,
                            AnnualCost = 8750.0,
                            DegreeId = 4,
                            SchoolId = 7,
                            StudyYears = 4,
                            TotalCost = 35000.0
                        },
                        new
                        {
                            Id = 33,
                            AnnualCost = 4000.0,
                            DegreeId = 4,
                            SchoolId = 8,
                            StudyYears = 4,
                            TotalCost = 16000.0
                        },
                        new
                        {
                            Id = 34,
                            AnnualCost = 900.0,
                            DegreeId = 4,
                            SchoolId = 10,
                            StudyYears = 4,
                            TotalCost = 3600.0
                        },
                        new
                        {
                            Id = 35,
                            AnnualCost = 12500.0,
                            DegreeId = 6,
                            SchoolId = 9,
                            StudyYears = 1,
                            TotalCost = 12500.0
                        },
                        new
                        {
                            Id = 36,
                            AnnualCost = 12500.0,
                            DegreeId = 7,
                            SchoolId = 9,
                            StudyYears = 1,
                            TotalCost = 12500.0
                        },
                        new
                        {
                            Id = 37,
                            AnnualCost = 12500.0,
                            DegreeId = 8,
                            SchoolId = 9,
                            StudyYears = 1,
                            TotalCost = 12500.0
                        },
                        new
                        {
                            Id = 38,
                            AnnualCost = 7500.0,
                            DegreeId = 9,
                            SchoolId = 9,
                            StudyYears = 1,
                            TotalCost = 7500.0
                        });
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BenefitCostAnalysisRatio")
                        .HasColumnType("int");

                    b.Property<double>("CashPaid")
                        .HasColumnType("float");

                    b.Property<int>("DegreeSchoolId")
                        .HasColumnType("int");

                    b.Property<bool>("FinWorkBenchStep")
                        .HasColumnType("bit");

                    b.Property<double>("FutureCareerEarnings")
                        .HasColumnType("float");

                    b.Property<double>("Grants")
                        .HasColumnType("float");

                    b.Property<double>("LoanAmount")
                        .HasColumnType("float");

                    b.Property<int>("LoanLengthMonths")
                        .HasColumnType("int");

                    b.Property<int>("LoanLengthYears")
                        .HasColumnType("int");

                    b.Property<double>("LoanPayment")
                        .HasColumnType("float");

                    b.Property<double>("LoanRate")
                        .HasColumnType("float");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Scholarships")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmountPaid")
                        .HasColumnType("float");

                    b.Property<double>("TotalLoanPayments")
                        .HasColumnType("float");

                    b.Property<double>("TotalSchoolCost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DegreeSchoolId")
                        .IsUnique();

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.MyCareerOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DegreeSchoolId")
                        .HasColumnType("int");

                    b.Property<bool>("SearchSchool")
                        .HasColumnType("bit");

                    b.Property<bool>("ShortList")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("DegreeSchoolId");

                    b.ToTable("MyCareerOption");
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnAction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnController")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("School");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "",
                            City = "",
                            SchoolName = "MTSU",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 2,
                            Address = "",
                            City = "",
                            SchoolName = "Tennesse Tech",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 3,
                            Address = "",
                            City = "",
                            SchoolName = "Vanderbilt",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 4,
                            Address = "",
                            City = "",
                            SchoolName = "U of I Chicago",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 5,
                            Address = "",
                            City = "",
                            SchoolName = "U of I Urbana",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 6,
                            Address = "",
                            City = "",
                            SchoolName = "Kentucky State",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 7,
                            Address = "",
                            City = "",
                            SchoolName = "University of OH",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 8,
                            Address = "",
                            City = "",
                            SchoolName = "Columbia State",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 9,
                            Address = "",
                            City = "",
                            SchoolName = "Nashville School of Software",
                            State = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 10,
                            Address = "",
                            City = "",
                            SchoolName = "Bubbas School of Learning",
                            State = "",
                            Zip = ""
                        });
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.DegreeSchool", b =>
                {
                    b.HasOne("SchoolScoreMVC.Models.Degree", "Degree")
                        .WithMany("DegreeSchools")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolScoreMVC.Models.School", "School")
                        .WithMany("DegreeSchools")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.Loan", b =>
                {
                    b.HasOne("SchoolScoreMVC.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Loans")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolScoreMVC.Models.DegreeSchool", "DegreeSchool")
                        .WithOne("Loan")
                        .HasForeignKey("SchoolScoreMVC.Models.Loan", "DegreeSchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolScoreMVC.Models.MyCareerOption", b =>
                {
                    b.HasOne("SchoolScoreMVC.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("MyCareerOptions")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolScoreMVC.Models.DegreeSchool", "DegreeSchool")
                        .WithMany()
                        .HasForeignKey("DegreeSchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
