using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolScoreMVC.Data;
using SchoolScoreMVC.Models;
//using SchoolScoreMVC.Models.DegreeViewModels;
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
        public async Task<ActionResult> Index(string filter)
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

        // GET: Loan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loan/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Editing a Loan with Workbench for the school-degree based on the degreeId passed when user clicks 
        // Begin Analysis within SchoolMatch view
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // GET: Loan/WorkBench?DegreeId=5
        public async Task<ActionResult> Workbench(int degreeId)
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

                // Grab the schools

                var degree = await _context.Degree

                       .Include(d => d.DegreeSchools)
                       .ThenInclude(d => d.School)
                       .FirstOrDefaultAsync(d => d.Id == degreeId);

                viewModel.DegreeId = degree.Id;
                viewModel.DegreeName = degree.EducationName;

                viewModel.Schools = degree.DegreeSchools.Select(ds => new SingleLoanViewModel()
                {

                    SchoolName = ds.School.SchoolName,
                    AnnualCost = ds.AnnualCost.ToString("c"),
                    TotalCost = ds.TotalCost.ToString("c"),
                    SchoolId = ds.SchoolId

                }).ToList();


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