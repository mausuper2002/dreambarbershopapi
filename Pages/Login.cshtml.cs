using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.Pages
{
    public class Login : PageModel
    {
        public void OnGet()
        {
            // Add any initialization code for the login page here
        }

        public IActionResult OnPost(string username, string password)
        {
            // Add logic to handle login
            if (username == "admin" && password == "password") // Dummy check
            {
                return RedirectToPage("/Index"); // Redirect to home page after successful login
            }

            return Page(); // Stay on the login page if credentials are invalid
        }
    }
}