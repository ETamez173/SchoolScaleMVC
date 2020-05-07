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



        //  GET: localhost:5001/School/search?degree=3
        public async Task<ActionResult> Search(int degreeId)
        {
            var user = await GetCurrentUserAsync();

            var viewModel = new SchoolSearchViewModel();
            //var viewModel = new List<SchoolSearchViewModel>();

            var schools = await _context.School
                    //.Where(s => s.DegreeSchools. == degreeId)
                        .Include(s => s.DegreeSchools)
                        .ThenInclude(s => s.Degree)
                        .Where(d => d.Id == degreeId)
                        .ToListAsync();

            viewModel.Schools = schools;
 

            return View(viewModel);
        }

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
            //if they are and the filter is cart, show them their cart
            //else if (filter == "history")


                else
            {


                // build the item as a view model so we can show more information
                var viewModel = new MatchingSchoolsViewModel();
                //var viewModel = new OrderHistoryViewModel();

                // Grab the schools


                var schools = await _context.School
                        //.Where(s => s.DegreeSchools. == degreeId)
                        .Include(s => s.DegreeSchools)
                        .ThenInclude(s => s.Degree)
                        .Where(d => d.Id == degreeId)
                        .ToListAsync();


                // commented out below to see if code will render anything
                //var schools = await _context.School
                //                    .Where(s => s.UserId == user.Id)
                //                    .Include(u => user.PaymentTypes)
                //                    .Include(u => u.OrderProducts)
                //                    .ThenInclude(op => op.Product)
                //                    .Where(o => o.PaymentType != null).ToListAsync();


                //var orders = await _context.Order
                //                 .Where(o => o.UserId == user.Id)
                //                 .Include(u => user.PaymentTypes)
                //                 .Include(u => u.OrderProducts)
                //                 .ThenInclude(op => op.Product)
                //                 .Where(o => o.PaymentType != null).ToListAsync();







                //build a list of the individual lines of products in the cart to show the quantity and price


                // commented out below to see if code will render anything
                //  may not need this view detailViewModels if I dont need to tally any items under each school like pending orders needed to do



                var detailViewModels = new List<SingleSchoolMatchViewModel>();
                //var detailViewModels = new List<OrderDetailViewModel>();



                //// commented out below to see if code will render anything


                //foreach (var school in schools)
                ////foreach (var order in orders)
                //{

                //    order.PaymentType = _context.PaymentType.FirstOrDefault(pt => pt.PaymentTypeId == order.PaymentTypeId);

                //    var lineItems = order.DegreeSchool.Select(op => new SchoolLineItem()
                //    //var lineItems = order.OrderProducts.Select(op => new OrderLineItem()

                //    {
                //        Product = op.Product,
                //        Units = op.Product.Quantity,
                //        Cost = op.Product.Price,
                //    }); ;
                //    var schoolViewModel = new SingleSchoolMatchViewModel();
                //    //var orderViewModel = new OrderDetailViewModel();
                //    orderViewModel.LineItems = lineItems;
                //    orderViewModel.Order = order;
                //    orderViewModel.Order.PaymentType = order.PaymentType;
                //    orderViewModel.OrderId = order.OrderId;
                //    detailViewModels.Add(orderViewModel);

                //    //ViewBag.ordertotal = lineItems.Sum(li => li.Cost);
                //    schoolViewModel.OrderTotalCost = lineItems.Sum(li => li.Cost);
                //    //orderViewModel.OrderTotalCost = lineItems.Sum(li => li.Cost);

                //}



                viewModel.Schools = detailViewModels;

                //viewModel.Orders = detailViewModels;



                return View(viewModel);

            }

            // commented out below to see if code will render anything

            //else
            //{
            //    return RedirectToAction(nameof(Unauthorized));
            //}

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