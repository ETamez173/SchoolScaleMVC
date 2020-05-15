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

               

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // adding matching schools that offer the degree based on the degreeId passed when user clicks 
        // Find Schools within Degree Index view
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // GET: Schools with Degree 

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
                       .ThenInclude(ds => ds.School)
                       .FirstOrDefaultAsync(d => d.Id == degreeId);

                viewModel.DegreeId = degree.Id;
                viewModel.DegreeName = degree.EducationName;

                viewModel.Schools = degree.DegreeSchools.Select(ds => new SingleSchoolMatchViewModel()
                {

                    SchoolName = ds.School.SchoolName,
                    State = ds.School.State,
                    AnnualCost = ds.AnnualCost.ToString("c"),
                    TotalCost = ds.TotalCost.ToString("c"),
                    SchoolId = ds.SchoolId,
                    DegreeId = ds.DegreeId

                }).ToList();


                return View(viewModel);

            }

        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        //// GET: School/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        /// GET: School/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
 
            var school = await _context.School
            
                .FirstOrDefaultAsync(m => m.Id == id)
                ;
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }



  






        // GET: School/Create
        public ActionResult Create()
        {

            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        // POST: School/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
             public async Task<IActionResult> Create([Bind("Id,SchoolName,Address,City,State, Zip")] School school)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                _context.School.Add(school);
                await _context.SaveChangesAsync();


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

        //// GET: School/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: School/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //===========================================
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
               .FirstOrDefaultAsync(l => l.Id == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var school = await _context.School.FindAsync(id);
            _context.School.Remove(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }







        // vid part 9 at 22.40 min pt
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}