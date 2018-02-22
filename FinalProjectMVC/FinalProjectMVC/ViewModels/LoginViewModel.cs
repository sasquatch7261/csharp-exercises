using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectMVC.ViewModels
{
    //Create LoginViewModel to be able to validate user input in the login form
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(7)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //Create LoginViewModel constructor to take in arguments
        public LoginViewModel(string username, string password, string verify, string email)
        {
            Username = username;
            Password = password;
            Verify = verify;
            Email = email;
        }
    }
}
