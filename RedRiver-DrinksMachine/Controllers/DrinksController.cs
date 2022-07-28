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
    }
}