using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedRiver_DrinksMachine.Recipes
{
    public abstract class RecipeBase
    {
        public abstract List<string> GetSteps();
    }
}