using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController1 : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.cheeses = Cheeses;

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/CheeseController1/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            Cheeses.Add(name, description);
            return Redirect("/CheeseController1");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        [HttpPost]
        [Route("/CheeseController1/Delete")]
        public IActionResult DeleteCheese(string[] cheese)
        {
            foreach (string che in cheese)
            {
                if (Cheeses.ContainsKey(che))
                {
                    Cheeses.Remove(che);
                }
            }

            //Cheeses.Remove(pair.Key, pair.Value);

            return Redirect("/CheeseController1");
        }

    }
}
