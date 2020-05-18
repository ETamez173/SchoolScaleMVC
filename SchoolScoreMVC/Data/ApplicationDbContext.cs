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

//            modelBuilder.Entity<Degree>().HasData(
//               new Degree()
//               {
//                   Id = 1,
//                   EducationName = "Electical Engineer",
//                   EarningAvg = 90000,
//                   EarningHigh = 98000,
//                   EarningLow = 84000

//               },
//                new Degree()
//                {
//                    Id = 2,
//                    EducationName = "Chemical Engineer",
//                    EarningAvg = 90000,
//                    EarningHigh = 98000,
//                    EarningLow = 84000
//                },
//                new Degree()
//                {
//                    Id = 3,
//                    EducationName = "Registered Nurse",
//                    EarningAvg = 60000,
//                    EarningHigh = 73000,
//                    EarningLow = 55000
//                },
//                new Degree()
//                {
//                    Id = 4,
//                    EducationName = "Computer Science",
//                    EarningAvg = 95000,
//                    EarningHigh = 105000,
//                    EarningLow = 80000
//                },
//                new Degree()
//                {
//                    Id = 5,
//                    EducationName = "Liberal Arts",
//                    EarningAvg = 30000,
//                    EarningHigh = 38000,
//                    EarningLow = 24000
//                },
//                new Degree()
//                {
//                    Id = 6,
//                    EducationName = "Full Stack Software Developer",
//                    EarningAvg = 95000,
//                    EarningHigh = 105000,
//                    EarningLow = 80000
//                },
//                new Degree()
//                {
//                    Id = 7,
//                    EducationName = "Front-End Web Designer Developer",
//                    EarningAvg = 95000,
//                    EarningHigh = 105000,
//                    EarningLow = 80000
//                },
//                new Degree()
//                {
//                    Id = 8,
//                    EducationName = "Data Science",
//                    EarningAvg = 95000,
//                    EarningHigh = 105000,
//                    EarningLow = 80000
//                },
//                new Degree()
//                {
//                    Id = 9,
//                    EducationName = "Data Analytics",
//                    EarningAvg = 95000,
//                    EarningHigh = 105000,
//                    EarningLow = 80000
//                }



//);


            modelBuilder.Entity<School>().HasData(
               new School()
               {
                   Id = 1,
                   SchoolName = "MTSU",
                   Address = "",
                   City = "",
                   State = "",
                   Zip = ""
               },
                new School()
                {
                    Id = 2,
                    SchoolName = "Tennesse Tech",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
        
                new School()
                {
                    Id = 3,
                    SchoolName = "Vanderbilt",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 4,
                    SchoolName = "U of I Chicago",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 5,
                    SchoolName = "U of I Urbana",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 6,
                    SchoolName = "Kentucky State",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 7,
                    SchoolName = "University of OH",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 8,
                    SchoolName = "Columbia State",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 9,
                    SchoolName = "Nashville School of Software",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                },
                new School()
                {
                    Id = 10,
                    SchoolName = "Bubbas School of Learning",
                    Address = "",
                    City = "",
                    State = "",
                    Zip = ""
                }

               );


            //modelBuilder.Entity<DegreeSchool>().HasData(
            //    new DegreeSchool()
            //    {
            //    Id = 1,
            //    SchoolId = 1,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 12500,
            //    TotalCost = 50000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 2,
            //    SchoolId = 2,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 25000,
            //    TotalCost = 100000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 3,
            //    SchoolId = 3,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 25000,
            //    TotalCost = 100000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 4,
            //    SchoolId = 4,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 20000,
            //    TotalCost = 80000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 5,
            //    SchoolId = 5,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 12000,
            //    TotalCost = 48000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 6,
            //    SchoolId = 6,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 8000,
            //    TotalCost = 32000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 7,
            //    SchoolId = 7,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 10000,
            //    TotalCost = 40000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 8,
            //    SchoolId = 8,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 6500,
            //    TotalCost = 26000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 9,
            //    SchoolId = 10,
            //    DegreeId = 1,
            //    StudyYears = 4,
            //    AnnualCost = 1200,
            //    TotalCost = 4800
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 10,
            //    SchoolId = 1,
            //    DegreeId = 2,
            //    StudyYears = 4,
            //    AnnualCost = 11250,
            //    TotalCost = 45000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 11,
            //    SchoolId = 2,
            //    DegreeId = 2,
            //    StudyYears = 4,
            //    AnnualCost = 13000,
            //    TotalCost = 52000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 12,
            //    SchoolId = 4,
            //    DegreeId = 2,
            //    StudyYears = 4,
            //    AnnualCost = 22000,
            //    TotalCost = 88000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 13,
            //    SchoolId = 5,
            //    DegreeId = 2,
            //    StudyYears = 4,
            //    AnnualCost = 21000,
            //    TotalCost = 84000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 14,
            //    SchoolId = 7,
            //    DegreeId = 2,
            //    StudyYears = 4,
            //    AnnualCost = 10500,
            //    TotalCost = 42000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 15,
            //    SchoolId = 10,
            //    DegreeId = 2,
            //    StudyYears = 4,
            //    AnnualCost = 1200,
            //    TotalCost = 4800
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 16,
            //    SchoolId = 1,
            //    DegreeId = 5,
            //    StudyYears = 4,
            //    AnnualCost = 8500,
            //    TotalCost = 34000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 17,
            //    SchoolId = 4,
            //    DegreeId = 5,
            //    StudyYears = 4,
            //    AnnualCost = 15000,
            //    TotalCost = 60000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 18,
            //    SchoolId = 1,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 9500,
            //    TotalCost = 38000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 19,
            //    SchoolId = 3,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 13000,
            //    TotalCost = 52000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 20,
            //    SchoolId = 4,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 20000,
            //    TotalCost = 80000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 21,
            //    SchoolId = 5,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 16000,
            //    TotalCost = 64000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 22,
            //    SchoolId = 6,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 7500,
            //    TotalCost = 30000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 23,
            //    SchoolId = 7,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 9000,
            //    TotalCost = 36000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 24,
            //    SchoolId = 8,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 7000,
            //    TotalCost = 28000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 25,
            //    SchoolId = 10,
            //    DegreeId = 3,
            //    StudyYears = 4,
            //    AnnualCost = 800,
            //    TotalCost = 3200
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 26,
            //    SchoolId = 1,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 10000,
            //    TotalCost = 40000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 27,
            //    SchoolId = 2,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 10000,
            //    TotalCost = 40000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 28,
            //    SchoolId = 3,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 16000,
            //    TotalCost = 64000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 29,
            //    SchoolId = 4,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 21000,
            //    TotalCost = 84000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 30,
            //    SchoolId = 5,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 20000,
            //    TotalCost = 80000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 31,
            //    SchoolId = 6,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 9000,
            //    TotalCost = 36000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 32,
            //    SchoolId = 7,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 8750,
            //    TotalCost = 35000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 33,
            //    SchoolId = 8,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 4000,
            //    TotalCost = 16000
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 34,
            //    SchoolId = 10,
            //    DegreeId = 4,
            //    StudyYears = 4,
            //    AnnualCost = 900,
            //    TotalCost = 3600
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 35,
            //    SchoolId = 9,
            //    DegreeId = 6,
            //    StudyYears = 1,
            //    AnnualCost = 12500,
            //    TotalCost = 12500
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 36,
            //    SchoolId = 9,
            //    DegreeId = 7,
            //    StudyYears = 1,
            //    AnnualCost = 12500,
            //    TotalCost = 12500
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 37,
            //    SchoolId = 9,
            //    DegreeId = 8,
            //    StudyYears = 1,
            //    AnnualCost = 12500,
            //    TotalCost = 12500
            //    },
            //    new DegreeSchool()
            //    {
            //    Id = 38,
            //    SchoolId = 9,
            //    DegreeId = 9,
            //    StudyYears = 1,
            //    AnnualCost = 7500,
            //    TotalCost = 7500
            //    }
               

            //   );

        }
    }
}
