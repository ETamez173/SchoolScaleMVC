using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public List<MyCareerOption> MyCareerOptions { get; set; }
        // user can have many career options

        public List<Loan> Loans { get; set; }
        // user can have many loans

    }
}
