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

namespace SchoolScoreMVC.Controllers
{
    public class SchoolController : Controller
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public SchoolController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: localhost:5001/school
        public async Task<ActionResult> Index()
        //public async Task<ActionResult> Index(string filter)
        {

            var user = await GetCurrentUserAsync();
            var items = await _context.School

                .ToListAsync();

            return View(items);
        }



        //  GET: //localhost:5001/School/Search?degreeId=2
        //public async Task<ActionResult> Search(int degreeId)
        //{
        //    var user = await GetCurrentUserAsync();

        //    var viewModel = new SchoolSearchViewModel();
        //    //var viewModel = new List<SchoolSearchViewModel>();

        //    //var schools = await _context.School
        //        var schools = await _context.Degree
        //                //.Where(s => ds.DegreeId == degreeId)
        //                .Where(d => d.Id == degreeId)
        //                .Include(d => d.DegreeSchools)
        //                .ThenInclude(ds => ds.School)

        //                .ToListAsync();

        //    viewModel.Degree = schools;


        //    return View(viewModel);
        //}

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // adding matching schools that offer the degree based on the degreeId passed when user clicks 
        // Find Schools
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // GET: Schools with Degree localhost:5001/School/SchoolMatch/

        // localhost:5001/School/SchoolMatch?degreeId=2

        public async Task<ActionResult> SchoolMatch(int degreeId)
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
                var viewModel = new MatchingSchoolsViewModel();

                // Grab the schools

                var degree = await _context.Degree

                       .Include(d => d.DegreeSchools)
                       .ThenInclude(d => d.School)
                       .FirstOrDefaultAsync(d => d.Id == degreeId);

                viewModel.DegreeId = degree.Id;
                viewModel.DegreeName = degree.EducationName;

                viewModel.Schools = degree.DegreeSchools.Select(ds => new SingleSchoolMatchViewModel()
                {

                    SchoolName = ds.School.SchoolName,
                    AnnualCost = ds.AnnualCost.ToString("c"),
                    TotalCost = ds.TotalCost.ToString("c"),
                    SchoolId = ds.SchoolId

                }).ToList();


                return View(viewModel);

            }

        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // GET: School/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: School/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: School/Create
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

        // GET: School/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: School/Edit/5
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

        // GET: School/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: School/Delete/5
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