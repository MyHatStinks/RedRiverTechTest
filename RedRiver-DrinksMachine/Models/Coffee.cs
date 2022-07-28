using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedRiver_DrinksMachine.Recipes
{
    public class Coffee : RecipeBase
    {
        public override List<string> GetSteps()
            => new List<string>()
            {
                "Boil some water",
                "Brew the coffee grounds",
                "Pour coffee in the cup",
                "Add sugar and milk",
            };
    }
}