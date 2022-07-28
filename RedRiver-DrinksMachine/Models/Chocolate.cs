using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedRiver_DrinksMachine.Recipes
{
    public class Chocolate : RecipeBase
    {
        public override List<string> GetSteps()
            => new List<string>()
            {
                "Boil some water",
                "Add drinking chocolate powder to the water",
                "Pour chocolate in the cup",
            };
    }
}