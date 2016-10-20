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

            ViewBag.Brewery = "Clown Shoes";
            ViewBag.Beer = "The Barista";
            ViewBag.Year = "2016";
            ViewBag.Description = "<p><strong>The Barista Breakfast Brown</strong> is crafted with Maris Otter malt, flaked oatmeal, cold brewed espresso, milk sugar and the spirit of angel wings.</p>";
            ViewBag.BeerDetails = new string[]
            {
                "style: brown ale",
                "brewdate: 2016",
                "brewery: Clown Shoes",
                "size: 22 Oz Bombers",
                "availability: available"
            };

            return View();
        }
    }
}