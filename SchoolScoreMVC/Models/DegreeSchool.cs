using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class DegreeSchool
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int SchoolId { get; set; }

        [Required]
        public School School { get; set; }

        [Required]
        public int DegreeId { get; set; }

        [Required]
        public Degree Degree { get; set; }

        public int StudyYears { get; set; }
        public double AnnualCost { get; set; }
        public double TotalCost { get; set; }

        //[Required]
        //public int LoanId { get; set; }

        //[Required]
        public Loan Loan { get; set; }

    }
}
