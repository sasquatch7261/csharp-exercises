using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudioThree.Controllers
{
    public class HomeController1 : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("Hello World");
        }

        public IActionResult Goodbye()
        {
            return Content("<h1>Goodbye</h1>", "text/html");
        }

        [HttpGet]
        public IActionResult Display()
        {
            string html = @"<form method='POST' action='/HomeController1/CreateMessage'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                "<option value='English'>English</option>" +
                "<option value='Polish'>Polish</option>" +
                "<option value='French'>French</option>" +
                "<option value='German'>German</option>" +
                "<option value='Italian'>Italian</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' /></form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        public IActionResult CreateMessage(string name, string language)
        {
            if (language == "Polish")
            {
                return Content(string.Format("<h1>Czesc, {0}!</h1>", name), "text/html");
            }
            else if (language == "French")
            {
                return Content(string.Format("<h1>Bonjour, {0}!</h1>", name), "text/html");
            }
            else if (language == "German")
            {
                return Content(string.Format("<h1>Hallo, {0}!</h1>", name), "text/html");
            }
            else if (language == "Italian")
            {
                return Content(string.Format("<h1>Ciao, {0}!</h1>", name), "text/html");
            }
            else
            {
                return Content(string.Format("<h1>Hello, {0}!</h1>", name), "text/html");
            }
        }
    }
}
