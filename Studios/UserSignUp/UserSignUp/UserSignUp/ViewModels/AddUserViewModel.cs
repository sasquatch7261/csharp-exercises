using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignUp.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        [Compare("Password")]
        public string Verify { get; set; }
    }
}
