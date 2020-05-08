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

        public string DegreeName { get; set; }

        //public List<School> Schools { get; set; }


        public IEnumerable<SingleLoanViewModel> Schools { get; set; }




        [Required]
        public int Id { get; set; }

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

        [Display(Name = "Cash")]
        public double CashPaid { get; set; }

        [Display(Name = "Grants")]
        public double Grants { get; set; }


        [Display(Name = "Scholarships")]
        public double Scholarships { get; set; }

        [Display(Name = "Total Amounts Paid")]
        public double TotalAmountPaid { get; set; }

        [Display(Name = "Career Earnings")]
        public double FutureCareerEarnings { get; set; }

        [Display(Name = "Benefits To Costs Ratio")]
        public int BenefitCostAnalysisRatio { get; set; }
        public Boolean FinWorkBenchStep { get; set; }

        //public int CustomerId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        // Ask Adam if I should remove this !!!!!!
        // one user can have many loans 

        public int DegreeSchoolId { get; set; }

        public DegreeSchool DegreeSchool
        {
            get; set;



        }
    }
}