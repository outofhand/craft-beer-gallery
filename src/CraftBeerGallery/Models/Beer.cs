using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraftBeerGallery.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string BeerName { get; set; }
        public string Brewery { get; set; }
        public string BreweryLocation { get; set; }
        public string Style { get; set; }
        public int ABV { get; set; }
        public string DescriptionHtml { get; set; }
        public string Availability { get; set; }
        public Attributes[] BeerAttributes { get; set; }
        public bool Favorite { get; set; }
    }

}