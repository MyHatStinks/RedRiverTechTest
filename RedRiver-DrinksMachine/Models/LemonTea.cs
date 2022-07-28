using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedRiver_DrinksMachine.Recipes
{
    public class LemonTea : RecipeBase
    {
        public override List<string> GetSteps()
            => new List<string>()
            {
                "Boil water",
                "Steep the water in the tea",
                "Pour tea in the cup",
                "Add lemon",
            };
    }
}