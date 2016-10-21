using CraftBeerGallery.Data;
using CraftBeerGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraftBeerGallery.Controllers
{
    public class CraftBeerController : Controller
    {
        private BeerRepository _beerRepository = null;

        public CraftBeerController()
        {
            _beerRepository = new BeerRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var beer = _beerRepository.GetBeer(id.Value);

            return View(beer);
        }
    }
}