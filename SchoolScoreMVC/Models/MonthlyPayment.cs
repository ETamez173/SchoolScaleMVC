using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolScoreMVC.Models
{
    public class MonthlyPayment
    {

        public double loanAmount;
        public double yearlyInterestRate;
        public int numberOfPayments;

        public MonthlyPayment()
        {
            loanAmount = 0;
            yearlyInterestRate = 0;
            numberOfPayments = 0;
        }

        public MonthlyPayment(double loanAmount, double yearlyInterestRate, int numberOfPayments)
        {
            this.loanAmount = loanAmount;
            this.yearlyInterestRate = yearlyInterestRate;
            this.numberOfPayments = numberOfPayments;
        }

        public void DisplayObjectState()
        {
            Console.WriteLine("Loan Amount: {0}", this.loanAmount);
            Console.WriteLine("Yearly Interest Rate: {0}", this.yearlyInterestRate);
            Console.WriteLine("Number Of Payments: {0}", this.numberOfPayments);
        }

        public double MonthlyInterestRate()
        {
            return (this.yearlyInterestRate / 100 / 12);
        }


        public double MonthlyPaymentAmount()
        {
            double rate = yearlyInterestRate / 100 / 12;
            double denominator = Math.Pow((1 + rate), numberOfPayments) - 1;
            return (rate + (rate / denominator)) * loanAmount;
        }

        //public double MonthlyPaymentAmount()
        //{
        //    return Math.Pow(MonthlyInterestRate() * ((1 + MonthlyInterestRate())), numberOfPayments)

        //    / (Math.Pow((1 + MonthlyInterestRate()), numberOfPayments -1) * loanAmount;
        //}

        public double AmountPaidBack()
        {
            return (MonthlyPaymentAmount() * numberOfPayments);
        }

        public double InterestPaid()
        {
            return (MonthlyInterestRate() * numberOfPayments);
        }
    }
}
