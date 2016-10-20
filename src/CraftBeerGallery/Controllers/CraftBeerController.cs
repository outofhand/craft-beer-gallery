using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraftBeerGallery.Controllers
{
    public class CraftBeerController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
                //return new RedirectResult("/CraftBeer");
            }

            return Content("Hello");
        }
    }
}