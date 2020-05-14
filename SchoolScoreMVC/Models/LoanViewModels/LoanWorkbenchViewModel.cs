using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models.LoanViewModels
{
    public class LoanWorkbenchViewModel
    {
        public int DegreeId { get; set; }

        public int SchoolId { get; set; }

        public string DegreeName { get; set; }

        public string SchoolName { get; set; }

        //public List<School> Schools { get; set; }


        public IEnumerable<SingleLoanViewModel> Schools { get; set; }


        [Display(Name = "Total Cost")]
        public double TotalSchoolCost { get; set; }


        [Required]
        public int Id { get; set; }

        [Display(Name = "Loan Amount")]
        public double LoanAmount { get; set; }

        [Display(Name = "Interest Rate%")]
        public Double LoanRate { get; set; }


        [Display(Name = "Loan Months")]
        public int LoanLengthMonths { get; set; }


        [Display(Name = "Loan Period")]
        public int LoanLengthYears { get; set; }

        [Display(Name = "Monthly Payment")]
        public double LoanPayment { get; set; }

        [Display(Name = "Total Loan Principal & Interest Repaid")]
        public double TotalLoanPayments { get; set; }

        [Display(Name = "Your Contribution")]
        [Required(ErrorMessage = "Enter An Amount 0 and up")]
        [DataType(DataType.Currency)]
        public double CashPaid { get; set; }

        [Display(Name = "Available Grants")]
        [Required(ErrorMessage = "Enter An Amount 0 and up")]
        [DataType(DataType.Currency)]
        public double Grants { get; set; }


        [Display(Name = "Available Scholarships")]
        [Required(ErrorMessage = "Enter An Amount 0 and up")]
        [DataType(DataType.Currency)]
        public double Scholarships { get; set; }

        [Display(Name = "Total Amounts Paid")]
        public double TotalAmountPaid { get; set; }

        [Display(Name = "Career Earnings")]
        public double FutureCareerEarnings { get; set; }

        [Display(Name = "Benefits To Costs Ratio")]
        public int BenefitCostAnalysisRatio { get; set; }

        [Display(Name = "Add To Benefit Analysis")]
        public Boolean FinWorkBenchStep { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        //[Required]
        public ApplicationUser User { get; set; }


      
        // one user can have many loans 

        public int DegreeSchoolId { get; set; }

        public DegreeSchool DegreeSchool { get; set; }


        [Display(Name = "Notes")]
        public string Notes { get; set; }


    }
}