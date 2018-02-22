using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProjectMVC.Models;
using FinalProjectMVC.ViewModels;
using FinalProjectMVC.DataLayer;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectMVC.Controllers
{
    public class HomePageController : Controller
    {
        List<User> users = new List<User>();

        static public CommunityClass community = new CommunityClass("The Piper", "High", "North", "High");

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.community = community;
            return View();
        }

        // Method to render login page
        [HttpGet]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        //Take user input as LoginViewModel and create new User object
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User(loginViewModel.Username, loginViewModel.Password, loginViewModel.Email);

                //Add new User object to data store
                users.Add(newUser);

                return Redirect("/");
            }

            else return View(loginViewModel);
        }
    }
}
