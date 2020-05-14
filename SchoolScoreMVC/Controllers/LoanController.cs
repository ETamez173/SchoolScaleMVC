using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolScoreMVC.Data;
using SchoolScoreMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolScoreMVC.Models.SchoolViewModels;
using SchoolScoreMVC.Models.LoanViewModels;
using SchoolScoreMVC.Migrations;

namespace SchoolScoreMVC.Controllers
{
    public class LoanController : Controller
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public LoanController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: localhost:5001/loan

        public async Task<IActionResult> BCAIndex(LoanBenefitCostAnalysisViewModel bcaViewModel)
        //public async Task<IActionResult> BCAIndex(LoanBenefitCostAnalysisViewModel LoanBenefitCostAnalysisViewModel)
     
        {

            var user = await GetCurrentUserAsync();
            var items = await _context.Loan
        .Where(l => l.ApplicationUserId == user.Id)
                .ToListAsync();

            return View(items);
        }

        // GET: localhost:5001/loan
        public async Task<ActionResult> Index(string filter)
        //public async Task<IActionResult> BCAIndex(LoanBenefitCostAnalysisViewModel bcaViewModel)

        {

            var user = await GetCurrentUserAsync();
            var items = await _context.Loan
                .Where(l => l.ApplicationUserId == user.Id)
                .ToListAsync();

            return View(items);
        }



        // GET: Loan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET: Loan/Create
         public ActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }



        //GET: Loan/CreateLoan
        public ActionResult CreateLoan(int degreeId, int schoolId)
        {


            var LoanWorkbenchViewModel = new LoanWorkbenchViewModel()
            {
                SchoolId = schoolId,
                DegreeId = degreeId

            };

            return View(LoanWorkbenchViewModel);
        }

        //// POST: Loan/CreateLoan
        ////Loan/CreateLoan?degreeId=2&schoolId=5
      
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateLoan(int degreeId, int schoolId, LoanWorkbenchViewModel loanViewModel)

        //public async Task<ActionResult> CreateLoan(LoanWorkbenchViewModel loanViewModel)
        {
            try
            {

                var viewModel = new LoanWorkbenchViewModel();



                var user = await GetCurrentUserAsync();
               

                var degreeschool = await _context.DegreeSchool
                   .Include(ds => ds.Degree)
                   .Include(ds => ds.School)
                   .FirstOrDefaultAsync(ds => ds.DegreeId == loanViewModel.DegreeId && ds.SchoolId == loanViewModel.SchoolId);
                //=============================================================================================



                //loanViewModel.DegreeName = degreeschool.Degree.EducationName;
                //loanViewModel.SchoolName = degreeschool.School.SchoolName;


                //=============================================================================================
                var totalSchoolCost = degreeschool.TotalCost;
                var futureCareerEarnings = (degreeschool.Degree.EarningAvg * 20);


                // Define variables to help calculate the loan payments
                var loanAmount = (totalSchoolCost - (loanViewModel.CashPaid + loanViewModel.Grants + loanViewModel.Scholarships));
                var rateOfInterest = (loanViewModel.LoanRate / 100 ) / 12;
                var numberOfPayments = loanViewModel.LoanLengthYears * 12;

                var loanPayment = (loanAmount * rateOfInterest) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

                var totalLoanPayments = loanPayment * numberOfPayments;
                var totalCashGrantScholarships = loanViewModel.CashPaid + loanViewModel.Grants + loanViewModel.Scholarships;
                var totalAmountPaid = totalLoanPayments + totalCashGrantScholarships;
              
                var benefitCostRatio = futureCareerEarnings / totalAmountPaid;

                var loan = new Loan()
      
               
                {
                    FutureCareerEarnings = futureCareerEarnings,
                    TotalSchoolCost = totalSchoolCost,
                    CashPaid = loanViewModel.CashPaid,
                    Grants = loanViewModel.Grants,
                    Scholarships = loanViewModel.Scholarships,
                    LoanAmount = loanAmount,
                    LoanRate = loanViewModel.LoanRate,
                    LoanLengthYears = loanViewModel.LoanLengthYears,
                    LoanLengthMonths = loanViewModel.LoanLengthYears * 12,
                    LoanPayment = loanPayment,
                    FinWorkBenchStep = loanViewModel.FinWorkBenchStep,
                    ApplicationUserId = user.Id,
                    DegreeSchoolId = degreeschool.Id,
                    TotalLoanPayments = totalLoanPayments,
                    TotalAmountPaid = totalAmountPaid,
                    BenefitCostAnalysisRatio = Convert.ToInt32(benefitCostRatio)

                };

                 

                _context.Loan.Add(loan);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(BCAIndex));
            }
            catch (Exception ex)
            {
                return View();
            }
        }




        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Editing a Loan with Workbench for the school-degree based on the degreeId & 
        // schoolId passed when user clicks Begin Analysis within SchoolMatch view
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // GET: Loan/WorkBench?degreeId=2&schoolId=5   
        //      Loan/WorkBench?schoolId=5&degreeId=2
        public async Task<ActionResult> Workbench(int degreeId, int schoolId)
        {
            var user = await GetCurrentUserAsync();

            // Check if the user is logged in, if they aren't, return 401
            if (user == null)
            {
                return new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }

            else
            {

                // build the item as a view model so we can show more information
                var viewModel = new LoanWorkbenchViewModel();

                // Grab the loans

                var degreeschool = await _context.DegreeSchool
                        .Include(ds => ds.Degree)
                        .Include(ds => ds.School)
                       .FirstOrDefaultAsync(ds => ds.DegreeId == degreeId && ds.SchoolId == schoolId);

                viewModel.DegreeId = degreeId;
                viewModel.SchoolId = schoolId;
                viewModel.DegreeName = degreeschool.Degree.EducationName;
                viewModel.SchoolName = degreeschool.School.SchoolName;
                viewModel.TotalSchoolCost = degreeschool.TotalCost;
                viewModel.DegreeSchoolId = degreeschool.Id;


                return View(viewModel);

            }

        }

        // POST: Loan/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        //// GET: Loan/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Loan/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Loan/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //POST: Loan/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //    TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loan
               .FirstOrDefaultAsync(l => l.Id == id);
            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }





        // vid part 9 at 22.40 min pt
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}