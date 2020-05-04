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
                   EarningAvg = 90000,
                   EarningHigh = 98000,
                   EarningLow = 84000

               },
                new Degree()
                {
                    Id = 2,
                    EducationName = "Chemical Engineer",
                    EarningAvg = 90000,
                    EarningHigh = 98000,
                    EarningLow = 84000
                },
                new Degree()
                {
                    Id = 3,
                    EducationName = "Registered Nurse",
                    EarningAvg = 60000,
                    EarningHigh = 73000,
                    EarningLow = 55000
                },
                new Degree()
                {
                    Id = 4,
                    EducationName = "Computer Science",
                    EarningAvg = 95000,
                    EarningHigh = 105000,
                    EarningLow = 80000
                },
                new Degree()
                {
                    Id = 5,
                    EducationName = "Liberal Arts",
                    EarningAvg = 30000,
                    EarningHigh = 38000,
                    EarningLow = 24000
                },
                new Degree()
                {
                    Id = 6,
                    EducationName = "Full Stack Software Developer",
                    EarningAvg = 95000,
                    EarningHigh = 105000,
                    EarningLow = 80000
                },
                new Degree()
                {
                    Id = 7,
                    EducationName = "Front-End Web Designer Developer",
                    EarningAvg = 95000,
                    EarningHigh = 105000,
                    EarningLow = 80000
                },
                new Degree()
                {
                    Id = 8,
                    EducationName = "Data Science",
                    EarningAvg = 95000,
                    EarningHigh = 105000,
                    EarningLow = 80000
                },
                new Degree()
                {
                    Id = 9,
                    EducationName = "Data Analytics",
                    EarningAvg = 95000,
                    EarningHigh = 105000,
                    EarningLow = 80000
                }



);


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

        }
    }
}
