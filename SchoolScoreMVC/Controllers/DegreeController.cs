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
using SchoolScoreMVC.Models.DegreeViewModels;
using Microsoft.AspNetCore.Authorization;

namespace SchoolScoreMVC.Controllers
{
    [Authorize]
    public class DegreeController : Controller
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public DegreeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;


        }
        // GET: localhost:5001/degree
        public async Task<ActionResult> Index()
        {

            var user = await GetCurrentUserAsync();
            var items = await _context.Degree
                //.Where(d => d.ApplicationUser == user.Id)
                .ToListAsync();

            return View(items);
        }


        // GET: Degrees 
        //localhost:5001/Degree/Degreelist

        public async Task<ActionResult> DegreeList()
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
                var degrees = await _context.Degree.ToListAsync();

                return View(degrees);

            }

        }

        // GET: Modal for School Details


        public async Task<IActionResult> DetailsModal(int? id)
        {

            var degree = await _context.Degree
                .FirstOrDefaultAsync(m => m.Id == id)
                ;
            return View(degree);
        }

            

        /// GET: Degree/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degree = await _context.Degree
                .FirstOrDefaultAsync(m => m.Id == id)
                ;
            if (degree == null)
            {
                return NotFound();
            }

            return View(degree);
        }

         // GET: Degree/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id");

            return View();
        }

        // POST: Degree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,EducationName,EarningAvg,EarningHigh,EarningLow")] Degree degree)
        {
            try
            {


                var user = await GetCurrentUserAsync();

                _context.Degree.Add(degree);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        // GET: Degree/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var user = await GetCurrentUserAsync();

            if (user == null)
            {
                return new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }

            var degree = await _context.Degree.FindAsync(id);
            if (degree == null)
            {
                return NotFound();
            }
            {
                return View(degree);
            }
        }


        
        // POST: Degree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        public async Task<IActionResult> Edit(int id, Degree degree)
        {

            if (id != degree.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(degree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreeItemExists(degree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
       
        
        // GET: Degree/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Degree/Delete/5
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


        private bool DegreeItemExists(int id)
        {
            return _context.Degree.Any(e => e.Id == id);
        }
  
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}