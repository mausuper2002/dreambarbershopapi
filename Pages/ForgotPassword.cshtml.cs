using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.Pages
{
    public class ForgotPassword : PageModel
    {
  public void OnGet()
        {
            // Any initialization code for Forgot Password page
        }

        public IActionResult OnPost(string email)
        {
            // Logic to handle sending a password reset link to the user's email
            return RedirectToPage("/Login");
        }
    }
}