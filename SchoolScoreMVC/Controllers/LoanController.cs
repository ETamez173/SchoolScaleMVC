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
using Microsoft.AspNetCore.Authorization;

namespace SchoolScoreMVC.Controllers
{
    [Authorize]
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
        // this populates the BCA table with loans and figures
        public async Task<IActionResult> BCAIndex()

        {

            var user = await GetCurrentUserAsync();
            var items = await _context.Loan
                .Include(l => l.DegreeSchool)
                .ThenInclude(ds => ds.Degree)
                .Include(l => l.DegreeSchool)
                .ThenInclude(ds => ds.School)
                .Where(l => l.ApplicationUserId == user.Id)

                .ToListAsync();


            return View(items);
        }


        // GET: localhost:5001/loan
        public async Task<ActionResult> Index(string filter)
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

        //  Loan/CreateLoanCalc?degreeId=2&schoolId=5
        public async Task<ActionResult> CreateLoanCalc(int degreeId, int schoolId)
        {

            var user = await GetCurrentUserAsync();
            var Degreeschool = await _context.DegreeSchool
               .Include(ds => ds.Degree)
               .Include(ds => ds.School)
               .FirstOrDefaultAsync(ds => ds.DegreeId == degreeId && ds.SchoolId == schoolId);


            var totalSchoolCost = Degreeschool.TotalCost;
            var degreeName = Degreeschool.Degree.EducationName;
            var schoolName = Degreeschool.School.SchoolName;
            var degreesSchoolId = Degreeschool.Id;

            var LoanWorkbenchViewModel = new LoanWorkbenchViewModel()
            {
                SchoolId = schoolId,
                DegreeId = degreeId,
                TotalSchoolCost = totalSchoolCost,
                DegreeName = degreeName,
                SchoolName = schoolName,
                DegreeSchoolId = degreesSchoolId,

            };

            return View(LoanWorkbenchViewModel);
        }

        //// POST: Loan/CreateLoan
        ///Loan/CreateLoanCalc?degreeId=2&schoolId=5


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateLoanCalc(int degreeId, int schoolId, LoanWorkbenchViewModel loanViewModel)


        {
            try
            {

                var user = await GetCurrentUserAsync();
                var Degreeschool = await _context.DegreeSchool
                   .Include(ds => ds.Degree)
                   .Include(ds => ds.School)
                   .FirstOrDefaultAsync(ds => ds.DegreeId == loanViewModel.DegreeId && ds.SchoolId == loanViewModel.SchoolId);


                var totalSchoolCost = Degreeschool.TotalCost;
                var futureCareerEarnings = (Degreeschool.Degree.EarningAvg * 20);

                // Define variables to help calculate the loan payments
                var loanAmount = (totalSchoolCost - (loanViewModel.CashPaid + loanViewModel.Grants + loanViewModel.Scholarships));
                var rateOfInterest = (loanViewModel.LoanRate / 100) / 12;
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
                    DegreeSchoolId = Degreeschool.Id,
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

        {
            try
            {

                var user = await GetCurrentUserAsync();
                var Degreeschool = await _context.DegreeSchool
                   .Include(ds => ds.Degree)
                   .Include(ds => ds.School)
                   .FirstOrDefaultAsync(ds => ds.DegreeId == loanViewModel.DegreeId && ds.SchoolId == loanViewModel.SchoolId);


                var totalSchoolCost = Degreeschool.TotalCost;
                var futureCareerEarnings = (Degreeschool.Degree.EarningAvg * 20);


                // Define variables to help calculate the loan payments
                var loanAmount = (totalSchoolCost - (loanViewModel.CashPaid + loanViewModel.Grants + loanViewModel.Scholarships));
                var rateOfInterest = (loanViewModel.LoanRate / 100) / 12;
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
                    DegreeSchoolId = Degreeschool.Id,
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
                        .Include(ds => ds.Loan)
                        .FirstOrDefaultAsync(ds => ds.DegreeId == degreeId && ds.SchoolId == schoolId);

                viewModel.DegreeId = degreeId;
                viewModel.SchoolId = schoolId;
                viewModel.DegreeName = degreeschool.Degree.EducationName;
                viewModel.SchoolName = degreeschool.School.SchoolName;
                viewModel.TotalSchoolCost = degreeschool.TotalCost;
                viewModel.DegreeSchoolId = degreeschool.Id;

                viewModel.CashPaid = degreeschool.Loan.CashPaid;
                viewModel.Grants = degreeschool.Loan.Grants;
                viewModel.Scholarships = degreeschool.Loan.Scholarships;
                viewModel.LoanAmount = degreeschool.Loan.LoanAmount;
                viewModel.LoanLengthYears = degreeschool.Loan.LoanLengthYears;
                viewModel.LoanRate = degreeschool.Loan.LoanRate;
                viewModel.LoanPayment = degreeschool.Loan.LoanPayment;
                viewModel.LoanRate = degreeschool.Loan.LoanRate;


                return View(viewModel);

            }

        }

        // POST: Loan/Edit/5
        // Workbench POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)

        public async Task<IActionResult> EditWorkBench(int id, Loan loan)
        {
            if (id != loan.Id)
            {
                return NotFound();
            }

            try
            {
                _context.Update(loan);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanExists(loan.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            return RedirectToAction(nameof(Workbench));

        }



        // GET: Loan/Edit/5
        // This the Add Notes Update Notes

        public async Task<ActionResult> Edit(int id)
        {
            var user = await GetCurrentUserAsync();
            var viewModel = new LoanWorkbenchViewModel();
            var loan = await _context.Loan.FirstOrDefaultAsync(l => l.Id == id);

            if (loan.ApplicationUserId != user.Id)
            {
                return NotFound();
            }


            return View(viewModel);
        }

        // POST: Loan/Edit/5
        // This posts Notes to the Loan table
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Loan loan)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var foundLoan = await _context.Loan.FirstOrDefaultAsync(l => l.Id == id);
                foundLoan.Notes = loan.Notes;

                //loan.ApplicationUserId = user.Id;

                _context.Loan.Update(foundLoan);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(BCAIndex));
            }
            catch (Exception ex)
            {
                return View();
            }


        }



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

        /// POST: Loan/Delete/5
        /// This is used for deleting a BCAIndex list item
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loan = await _context.Loan.FindAsync(id);
            _context.Loan.Remove(loan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BCAIndex));
        }



        private bool DegreeSchoolExists(int id)
        {
            return _context.DegreeSchool.Any(e => e.Id == id);
        }

        private bool LoanExists(int id)
        {
            return _context.Loan.Any(e => e.Id == id);
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}