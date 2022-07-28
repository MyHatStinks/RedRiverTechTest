using RedRiver_DrinksMachine.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedRiver_DrinksMachine.Controllers
{
    public class DrinksController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BrewDrink(string drink)
        {
            if (string.IsNullOrWhiteSpace(drink))
            {
                throw new ArgumentException("Invalid drink specified.", nameof(drink));
            }

            // Quick and dirty, but suitable enough for only three drinks
            RecipeBase recipe;
            switch (drink.ToLower())
            {
                case "lemontea":
                    recipe = new LemonTea();
                    break;
                case "coffee":
                    recipe = new LemonTea();
                    break;
                case "chocolate":
                    recipe = new LemonTea();
                    break;
                default:
                    throw new ArgumentException("Invalid drink specified.", nameof(drink));
            }

            return PartialView("_Recipe", recipe);
        }
    }
}