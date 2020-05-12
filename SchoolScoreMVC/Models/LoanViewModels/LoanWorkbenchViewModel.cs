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
        public double TotalCost { get; set; }


        [Required]
        public int Id { get; set; }

        [Display(Name = "Loan Amount")]
        public double LoanAmount { get; set; }

        [Display(Name = "Interest Rate%")]
        public int LoanRate { get; set; }


        [Display(Name = "Loan Months")]
        public int LoanLengthMonths { get; set; }


        [Display(Name = "Loan Years")]
        public int LoanLengthYears { get; set; }

        [Display(Name = "Loan Payment")]
        public double LoanPayment { get; set; }

        [Display(Name = "Total Loan Payments")]
        public double TotalLoanPayments { get; set; }

        [Display(Name = "Cash")]
        [Required(ErrorMessage = "Enter An Amount 0 and up")]
        public double CashPaid { get; set; }

        [Display(Name = "Grants")]
        [Required(ErrorMessage = "Enter An Amount 0 and up")]
        public double Grants { get; set; }


        [Display(Name = "Scholarships")]
        [Required(ErrorMessage = "Enter An Amount 0 and up")]
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

        [Required]
        public ApplicationUser ApplicationUser { get; set; }


      
        // one user can have many loans 

        public int DegreeSchoolId { get; set; }

        public DegreeSchool DegreeSchool { get; set; }





    }
}