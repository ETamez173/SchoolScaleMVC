﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolScoreMVC.Models;

namespace SchoolScoreMVC.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
             UserManager<ApplicationUser> userManager,
             SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            // added LastName, StreetAddress,  PhoneNumber was already included

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "Address")]
            public string StreetAddress { get; set; }

        }

        private async Task LoadAsync(ApplicationUser user)
        {
           
          var currentUser = await _userManager.GetUserAsync(User);


            Username = currentUser.UserName;

            Input = new InputModel
            {
                PhoneNumber = currentUser.PhoneNumber,
                LastName = currentUser.LastName,
                FirstName = currentUser.FirstName,
                StreetAddress = currentUser.StreetAddress
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }


            var currentUser = await _userManager.GetUserAsync(User);
            if (Input.LastName != currentUser.LastName)
            {
                currentUser.LastName = Input.LastName;
                await _userManager.UpdateAsync(currentUser);

            }




            if (Input.FirstName != currentUser.FirstName)
            {
                currentUser.FirstName = Input.FirstName;
                //await _userManager.UpdateAsync(currentUser);

            }

            if (Input.StreetAddress != currentUser.StreetAddress)
            {
                currentUser.StreetAddress = Input.StreetAddress;
                await _userManager.UpdateAsync(currentUser);
            }



            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
