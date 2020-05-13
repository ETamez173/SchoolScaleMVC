﻿using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class Loan
    {

        [Required]
        public int Id { get; set; }

        [Display(Name = "Total School Cost")]
        public double TotalSchoolCost { get; set; }


        [Display(Name = "Loan Amount")]
        public double LoanAmount { get; set; }

        [Display(Name = "Interest Rate%")]
        public int LoanRate { get; set; }

        //should LoanRate be int or double?

        [Display(Name = "Loan Months")]
        public int LoanLengthMonths { get; set; }


        [Display(Name = "Loan Years")]
        public int LoanLengthYears { get; set; }

        [Display(Name = "Loan Payment")]
        public double LoanPayment { get; set; }

        [Display(Name = "Total Loan Payments")]
        public double TotalLoanPayments { get; set; }

        [Display(Name = "Your Contribution")]
        public double CashPaid { get; set; }

        [Display(Name = "Available Grants")]
        public double Grants { get; set; }


        [Display(Name = "Available Scholarships")]
        public double Scholarships { get; set; }

        [Display(Name = "Total Amounts Paid")]
        public double TotalAmountPaid { get; set; }

        [Display(Name = "Career Earnings")]
        public double FutureCareerEarnings { get; set; }

        [Display(Name = "Benefits To Costs Ratio")]


        public int BenefitCostAnalysisRatio { get; set; }

        [Display(Name = "Add To Benefit Analysis")]
        public Boolean FinWorkBenchStep { get; set; }

        //public int CustomerId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        //[Required]
        public ApplicationUser ApplicationUser { get; set; }
        // Ask Adam if I should remove this !!!!!!
        // one user can have many loans 

        public int DegreeSchoolId { get; set; }

        public DegreeSchool DegreeSchool { get; set; }

    }
}
