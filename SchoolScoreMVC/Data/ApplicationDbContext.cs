using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolScoreMVC.Models;

namespace SchoolScoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Degree> Degree { get; set; }

        public DbSet<DegreeSchool> DegreeSchool { get; set; }

        public DbSet<Loan> Loan { get; set; }

        public DbSet<MyCareerOption> MyCareerOption { get; set; }

        public DbSet<School> School { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            modelBuilder.Entity<Degree>().HasData(
               new Degree()
               {
                   Id = 1,
                   EducationName = "Electical Engineer",
                   EarningAvg = 94352,
                   EarningHigh = 103213,
                   EarningLow = 73721

               },
                new Degree()
                {
                    Id = 2,
                    EducationName = "Chemical Engineer",
                    EarningAvg = 87235,
                    EarningHigh = 92453,
                    EarningLow = 79440
                },
                new Degree()
                {
                    Id = 3,
                    EducationName = "Registered Nurse",
                    EarningAvg = 58340,
                    EarningHigh = 73431,
                    EarningLow = 48301
                },
                new Degree()
                {
                    Id = 4,
                    EducationName = "Computer Science",
                    EarningAvg = 94301,
                    EarningHigh = 106011,
                    EarningLow = 78704
                },
                new Degree()
                {
                    Id = 5,
                    EducationName = "Liberal Arts",
                    EarningAvg = 32476,
                    EarningHigh = 53010,
                    EarningLow = 24045
                },
                new Degree()
                {
                    Id = 6,
                    EducationName = "Full Stack Software Developer",
                    EarningAvg = 91402,
                    EarningHigh = 105910,
                    EarningLow = 78904
                },
                new Degree()
                {
                    Id = 7,
                    EducationName = "Front-End Web Designer Developer",
                    EarningAvg = 90401,
                    EarningHigh = 104201,
                    EarningLow = 77801
                },
                new Degree()
                {
                    Id = 8,
                    EducationName = "Data Science",
                    EarningAvg = 98704,
                    EarningHigh = 115230,
                    EarningLow = 83012
                },
                new Degree()
                {
                    Id = 9,
                    EducationName = "Data Analytics",
                    EarningAvg = 94431,
                    EarningHigh = 104878,
                    EarningLow = 82401
                }



);


            modelBuilder.Entity<School>().HasData(
               new School()
               {
                   Id = 1,
                   SchoolName = "MTSU",
                   Address = "1301 E. Main St.",
                   City = "Murfreesboro",
                   State = "TN",
                   Zip = "37132",
                   AlternateText = "MTSU Photo",
                   Photo = "MTSU.jpg"
               },
                new School()
                {
                    Id = 2,
                    SchoolName = "Tennesse Tech",
                    Address = "1 William L. Jones Dr.",
                    City = "Cookeville",
                    State = "TN",
                    Zip = "38505",
                    AlternateText = "Tennessee Tech Photo",
                    Photo = "TennTech.jpg"
                },

                new School()
                {
                    Id = 3,
                    SchoolName = "Vanderbilt",
                    Address = "2201 West End Ave.",
                    City = "Nashville",
                    State = "TN",
                    Zip = "37235",
                    AlternateText = "Vanderbilt Photo",
                    Photo = "Vanderbilt.jpg"
                },
                new School()
                {
                    Id = 4,
                    SchoolName = "University of Illinois Chicago",
                    Address = "1200 W. Harrison",
                    City = "Chicago",
                    State = "IL",
                    Zip = "60607",
                    AlternateText = "University of Illinois Chicago Photo",
                    Photo = "UofIChicago.jpg"
                },
                new School()
                {
                    Id = 5,
                    SchoolName = "University of Illinois Urbana",
                    Address = "1110 W. Springfield",
                    City = "Urbana",
                    State = "IL",
                    Zip = "61801",
                    AlternateText = "University of Illinois Urbana Photo",
                    Photo = "UofIUrbana.jpg"
                },
                new School()
                {
                    Id = 6,
                    SchoolName = "Kentucky State",
                    Address = "400 East Main St.",
                    City = "Frankfort",
                    State = "KY",
                    Zip = "40601",
                    AlternateText = "Kentucky State Photo",
                    Photo = "KentuckyState.jpg"
                },
                new School()
                {
                    Id = 7,
                    SchoolName = "Ohio University",
                    Address = "1 Ohio University",
                    City = "Athens",
                    State = "OH",
                    Zip = "45701",
                    AlternateText = "Ohio University Photo",
                    Photo = "OhioUniv.jpg"
                },
                new School()
                {
                    Id = 8,
                    SchoolName = "Columbia State",
                    Address = "1665 Hampshire Pike",
                    City = "Columbia",
                    State = "TN",
                    Zip = "38401",
                    AlternateText = "Columbia State Photo",
                    Photo = "ColumbiaState.jpg"
                },
                new School()
                {
                    Id = 9,
                    SchoolName = "Nashville School of Software",
                    Address = "301 Plus Park Blvd #300",
                    City = "Nashville",
                    State = "TN",
                    Zip = "37217",
                    AlternateText = "Nashville School of Software Photo",
                    Photo = "NSS.jpg"
                },
                new School()
                {
                    Id = 10,
                    SchoolName = "Bubbas School of Learning",
                    Address = "100 BBQ Lane",
                    City = "Nashville",
                    State = "TN",
                    Zip = "37217",
                    AlternateText = "Bubbas School of Learning Photo",
                    Photo = ""
                }

               );


            modelBuilder.Entity<DegreeSchool>().HasData(
                new DegreeSchool()
                {
                    Id = 1,
                    SchoolId = 1,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 12500,
                    TotalCost = 50000
                },
                new DegreeSchool()
                {
                    Id = 2,
                    SchoolId = 2,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 25000,
                    TotalCost = 100000
                },
                new DegreeSchool()
                {
                    Id = 3,
                    SchoolId = 3,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 25000,
                    TotalCost = 100000
                },
                new DegreeSchool()
                {
                    Id = 4,
                    SchoolId = 4,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 20000,
                    TotalCost = 80000
                },
                new DegreeSchool()
                {
                    Id = 5,
                    SchoolId = 5,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 12000,
                    TotalCost = 48000
                },
                new DegreeSchool()
                {
                    Id = 6,
                    SchoolId = 6,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 8000,
                    TotalCost = 32000
                },
                new DegreeSchool()
                {
                    Id = 7,
                    SchoolId = 7,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 10000,
                    TotalCost = 40000
                },
                new DegreeSchool()
                {
                    Id = 8,
                    SchoolId = 8,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 6500,
                    TotalCost = 26000
                },
                new DegreeSchool()
                {
                    Id = 9,
                    SchoolId = 10,
                    DegreeId = 1,
                    StudyYears = 4,
                    AnnualCost = 1200,
                    TotalCost = 4800
                },
                new DegreeSchool()
                {
                    Id = 10,
                    SchoolId = 1,
                    DegreeId = 2,
                    StudyYears = 4,
                    AnnualCost = 11250,
                    TotalCost = 45000
                },
                new DegreeSchool()
                {
                    Id = 11,
                    SchoolId = 2,
                    DegreeId = 2,
                    StudyYears = 4,
                    AnnualCost = 13000,
                    TotalCost = 52000
                },
                new DegreeSchool()
                {
                    Id = 12,
                    SchoolId = 4,
                    DegreeId = 2,
                    StudyYears = 4,
                    AnnualCost = 22000,
                    TotalCost = 88000
                },
                new DegreeSchool()
                {
                    Id = 13,
                    SchoolId = 5,
                    DegreeId = 2,
                    StudyYears = 4,
                    AnnualCost = 21000,
                    TotalCost = 84000
                },
                new DegreeSchool()
                {
                    Id = 14,
                    SchoolId = 7,
                    DegreeId = 2,
                    StudyYears = 4,
                    AnnualCost = 10500,
                    TotalCost = 42000
                },
                new DegreeSchool()
                {
                    Id = 15,
                    SchoolId = 10,
                    DegreeId = 2,
                    StudyYears = 4,
                    AnnualCost = 1200,
                    TotalCost = 4800
                },
                new DegreeSchool()
                {
                    Id = 16,
                    SchoolId = 1,
                    DegreeId = 5,
                    StudyYears = 4,
                    AnnualCost = 8500,
                    TotalCost = 34000
                },
                new DegreeSchool()
                {
                    Id = 17,
                    SchoolId = 4,
                    DegreeId = 5,
                    StudyYears = 4,
                    AnnualCost = 15000,
                    TotalCost = 60000
                },
                new DegreeSchool()
                {
                    Id = 18,
                    SchoolId = 1,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 9500,
                    TotalCost = 38000
                },
                new DegreeSchool()
                {
                    Id = 19,
                    SchoolId = 3,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 13000,
                    TotalCost = 52000
                },
                new DegreeSchool()
                {
                    Id = 20,
                    SchoolId = 4,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 20000,
                    TotalCost = 80000
                },
                new DegreeSchool()
                {
                    Id = 21,
                    SchoolId = 5,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 16000,
                    TotalCost = 64000
                },
                new DegreeSchool()
                {
                    Id = 22,
                    SchoolId = 6,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 7500,
                    TotalCost = 30000
                },
                new DegreeSchool()
                {
                    Id = 23,
                    SchoolId = 7,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 9000,
                    TotalCost = 36000
                },
                new DegreeSchool()
                {
                    Id = 24,
                    SchoolId = 8,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 7000,
                    TotalCost = 28000
                },
                new DegreeSchool()
                {
                    Id = 25,
                    SchoolId = 10,
                    DegreeId = 3,
                    StudyYears = 4,
                    AnnualCost = 800,
                    TotalCost = 3200
                },
                new DegreeSchool()
                {
                    Id = 26,
                    SchoolId = 1,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 10000,
                    TotalCost = 40000
                },
                new DegreeSchool()
                {
                    Id = 27,
                    SchoolId = 2,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 10000,
                    TotalCost = 40000
                },
                new DegreeSchool()
                {
                    Id = 28,
                    SchoolId = 3,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 16000,
                    TotalCost = 64000
                },
                new DegreeSchool()
                {
                    Id = 29,
                    SchoolId = 4,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 21000,
                    TotalCost = 84000
                },
                new DegreeSchool()
                {
                    Id = 30,
                    SchoolId = 5,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 20000,
                    TotalCost = 80000
                },
                new DegreeSchool()
                {
                    Id = 31,
                    SchoolId = 6,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 9000,
                    TotalCost = 36000
                },
                new DegreeSchool()
                {
                    Id = 32,
                    SchoolId = 7,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 8750,
                    TotalCost = 35000
                },
                new DegreeSchool()
                {
                    Id = 33,
                    SchoolId = 8,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 4000,
                    TotalCost = 16000
                },
                new DegreeSchool()
                {
                    Id = 34,
                    SchoolId = 10,
                    DegreeId = 4,
                    StudyYears = 4,
                    AnnualCost = 900,
                    TotalCost = 3600
                },
                new DegreeSchool()
                {
                    Id = 35,
                    SchoolId = 9,
                    DegreeId = 6,
                    StudyYears = 1,
                    AnnualCost = 12500,
                    TotalCost = 12500
                },
                new DegreeSchool()
                {
                    Id = 36,
                    SchoolId = 9,
                    DegreeId = 7,
                    StudyYears = 1,
                    AnnualCost = 12500,
                    TotalCost = 12500
                },
                new DegreeSchool()
                {
                    Id = 37,
                    SchoolId = 9,
                    DegreeId = 8,
                    StudyYears = 1,
                    AnnualCost = 12500,
                    TotalCost = 12500
                },
                new DegreeSchool()
                {
                    Id = 38,
                    SchoolId = 9,
                    DegreeId = 9,
                    StudyYears = 1,
                    AnnualCost = 7500,
                    TotalCost = 7500
                }


               );

        }
    }
}
