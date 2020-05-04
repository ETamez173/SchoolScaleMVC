using Microsoft.EntityFrameworkCore.Metadata;
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

        public double LoanAmount { get; set; }
        public int LoanRate { get; set; }

        //should LoanRate be int or double?
        public int LoanLengthMonths { get; set; }
        public int LoanLengthYears { get; set; }
        public double LoanPayment { get; set; }
        public double TotalLoanPayments { get; set; }
        public double CashPaid { get; set; }
        public double Grants { get; set; }
        public double Scholarships { get; set; }
        public double TotalAmountPaid { get; set; }

        public double FutureCareerEarnings { get; set; }
        public int BenefitCostAnalysisRatio { get; set; }
        public Boolean FinWorkBenchStep { get; set; }

        //public int CustomerId { get; set; }

        [Required]
        public int ApplicationUserId { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        // Ask Adam if I should remove this !!!!!!
        // one user can have many loans 


    }
}
