using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignUp.Models;
using UserSignUp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignUp.Controllers
{
    public class UserController : Controller
    {
        static public string username;
        static public string email;

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.username = username;
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new Models.User
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password,
                };

                username = addUserViewModel.Username;
                return Redirect("/User");

            }
            else
            {
                return View(addUserViewModel);
            }
            /**username = user.Username;
            email = user.Email;

            if (verify == user.Password)
            {
                return Redirect("/User/Index");
            }
            else
            {
                ViewBag.username = username;
                ViewBag.email = email;
                return View();
            }**/
        }
    }
}
