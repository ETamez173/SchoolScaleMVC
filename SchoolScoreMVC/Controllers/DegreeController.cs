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

namespace SchoolScoreMVC.Controllers
{
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
        public async Task<ActionResult> Index(string filter)
        {

            var user = await GetCurrentUserAsync();
            var items = await _context.Degree
                //.Where(d => d.ApplicationUser == user.Id)
                .ToListAsync();

            return View(items);
        }

        // GET: Degree/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Degree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Degree/Create
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

        // GET: Degree/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Degree/Edit/5
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
        // vid part 9 at 22.40 min pt
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}