using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.Pages
{
    public class Register : PageModel
    {
 public void OnGet()
        {
            // Any initialization code for Register page
        }

        public IActionResult OnPost(string username, string password, string confirmPassword)
        {
            // Check if passwords match
            if (password != confirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return Page();
            }

            // Logic to register the user
            // For example, save the user in the database
            return RedirectToPage("/Login");
        }
    }
}