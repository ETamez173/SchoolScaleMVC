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
        //public async Task<ActionResult> Index(string filter)
        public async Task<IActionResult> BCAIndex(LoanBenefitCostAnalysisViewModel bcaViewModel)

        {

            var user = await GetCurrentUserAsync();
            var items = await _context.Loan
       
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



        //POST: Loan/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]


        // public async Task<IActionResult> CreateLoan([Bind("LoanAmount,LoanRate,LoanLengthMonths,LoanLengthYears,LoanPayment,TotalLoanPayments,CashPaid,Grants,Scholarships,TotalAmountPaid,FutureCareerEarnings, BenefitCostAnalysisRatio, FinWorkBenchStep,ApplicationUserId, DegreeSchoolId")] Loan loan)
        //{
        //    try
        //    {

        //        var user = await GetCurrentUserAsync();
        //        loan.ApplicationUserId = user.Id;

        //        _context.Loan.Add(loan);
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}



        //GET: Loan/Create
        public ActionResult CreateLoan()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        //// POST: Loan/Create
        ////Loan/CreateLoan?degreeId=2&schoolId=5
      
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateLoan(int degreeId, int schoolId, LoanWorkbenchViewModel loanViewModel)
               //public async Task<ActionResult> CreateLoan(LoanWorkbenchViewModel loanViewModel)
        {
            try
            {

                var user = await GetCurrentUserAsync();


                //var degreeschool = await _context.DegreeSchool
                //    .Include(ds => ds.Degree)
                //    .Include(ds => ds.School)
                //    .Include(ds => ds.Id)
                //   .FirstOrDefaultAsync(ds => ds.DegreeId == degreeId && ds.SchoolId == schoolId);


                ////loanViewModel.DegreeId = degreeId;
                ////loanViewModel.SchoolId = schoolId;

                //loanViewModel.SchoolName = degreeschool.School.SchoolName;
                //loanViewModel.DegreeName = degreeschool.Degree.EducationName;

                //loanViewModel.Schools = degree.DegreeSchools.Select(ds => new SingleSchoolMatchViewModel()
                //{

                //    SchoolName = ds.School.SchoolName,
                //    State = ds.School.State,
                //    AnnualCost = ds.AnnualCost.ToString("c"),
                //    TotalCost = ds.TotalCost.ToString("c"),
                //    SchoolId = ds.SchoolId,
                //    DegreeId = ds.DegreeId

                //}).ToList();

                var loan = new Loan()


                {
                 
                    TotalSchoolCost = loanViewModel.TotalSchoolCost,
                    LoanRate = loanViewModel.LoanRate,
                    LoanLengthYears = loanViewModel.LoanLengthYears,
                    //LoanPayment = loanViewModel.LoanPayment,
                    CashPaid = loanViewModel.CashPaid,
                    Grants = loanViewModel.Grants,
                    Scholarships = loanViewModel.Scholarships,
                    FinWorkBenchStep = loanViewModel.FinWorkBenchStep,
                    //DegreeSchoolId = degreeschool.Id,
                    
                    //loanViewModel.SchoolName = degreeschool.School.SchoolName;


                };


            

                _context.Loan.Add(loan);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
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


                //viewModel.Schools = degreeschool.DegreeSchools.Select(ds => new SingleLoanViewModel()

                //{

                //    EducationName = degreeschool.Degree.EducationName,
                //    SchoolName = degreeschool.School.SchoolName,
                //    AnnualCost = degreeschool.AnnualCost.ToString("c"),
                //    TotalCost = degreeschool.TotalCost.ToString("c"),
                //    SchoolId = degreeschool.SchoolId

                //}).ToList();

                //////  //////  //////  //////  //////  //////  //////  ////// 
                ////// Loan Payment Code here???
                //////  //////  //////  //////  //////  //////  //////  ////// 
                ///

                var testDefault = new MonthlyPayment();
                testDefault.DisplayObjectState();
                Console.WriteLine("\n");

                var real = new MonthlyPayment(10000, 10, 36);
                real.DisplayObjectState();

                Console.WriteLine("\n");
                Console.WriteLine("Monthy Payment Amount: {0}", real.MonthlyPaymentAmount());
                Console.WriteLine("\n");
                Console.WriteLine("Amount Paid Back: {0}", real.AmountPaidBack());
                Console.WriteLine("\n");
                Console.WriteLine("Interest Paid: {0}", real.InterestPaid());

                Console.WriteLine("\n");
                //////  //////  //////  //////  //////  //////  //////  ////// 
                // Loan Payment Code here???
                //////  //////  //////  //////  //////  //////  //////  ////// 


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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Loan/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // vid part 9 at 22.40 min pt
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}