using CraftBeerGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraftBeerGallery.Data
{
    public class BeerRepository
    {
        private static Beer[] _beers = new Beer[]
        {
            new Beer()
            {
                BeerName = "The Barista",
                Brewery = "Clown Shoes",
                BreweryLocation = "Massachusetts, United States",
                Style = "American Brown Ale",
                ABV = 8.50,
                DescriptionHtml = "<p><strong>The Barista Breakfast Brown</strong> is crafted with Maris Otter malt, flaked oatmeal, cold brewed espresso, milk sugar and the spirit of angel wings.</p>",
                Availability = "Year-round",
                BeerAttributes = new Attributes[]
                {
                    new Attributes() {
                        Appearance = " A one finger off white head was poured that reduced to a thin layer. It is an amber brown color with no vision of anything. Spotty lacing down the glass as the beer was drank.",
                        Smell = "Roasted espresso coffee, oats, oatmeal, doughy, bready, some sweetness, and nutty.",
                        Taste = "Roastiness up front, nutty, oats, bready, chewy, doughy, some lactose sweetness, and light bitterness.",
                        Mouthfeel = "Smooth, chewy notes, roasted bitterness, medium bodied, and medium carbonation.",
                        Overall = "Got to admit that the toasted coffee compliments the nutty and oaty notes of this beer. Definitely could revisit this roasty brown ale."
                    }
                }
            },
            new Beer()
            {
                BeerName = "The Barista",
                Brewery = "Clown Shoes",
                BreweryLocation = "Massachusetts, United States",
                Style = "American Brown Ale",
                ABV = 8.50,
                DescriptionHtml = "<p><strong>The Barista Breakfast Brown</strong> is crafted with Maris Otter malt, flaked oatmeal, cold brewed espresso, milk sugar and the spirit of angel wings.</p>",
                Availability = "Year-round",
                BeerAttributes = new Attributes[]
                {
                    new Attributes() {
                        Appearance = " A one finger off white head was poured that reduced to a thin layer. It is an amber brown color with no vision of anything. Spotty lacing down the glass as the beer was drank.",
                        Smell = "Roasted espresso coffee, oats, oatmeal, doughy, bready, some sweetness, and nutty.",
                        Taste = "Roastiness up front, nutty, oats, bready, chewy, doughy, some lactose sweetness, and light bitterness.",
                        Mouthfeel = "Smooth, chewy notes, roasted bitterness, medium bodied, and medium carbonation.",
                        Overall = "Got to admit that the toasted coffee compliments the nutty and oaty notes of this beer. Definitely could revisit this roasty brown ale."
                    }
                }
            },
            new Beer()
            {
                BeerName = "The Barista",
                Brewery = "Clown Shoes",
                BreweryLocation = "Massachusetts, United States",
                Style = "American Brown Ale",
                ABV = 8.50,
                DescriptionHtml = "<p><strong>The Barista Breakfast Brown</strong> is crafted with Maris Otter malt, flaked oatmeal, cold brewed espresso, milk sugar and the spirit of angel wings.</p>",
                Availability = "Year-round",
                BeerAttributes = new Attributes[]
                {
                    new Attributes() {
                        Appearance = " A one finger off white head was poured that reduced to a thin layer. It is an amber brown color with no vision of anything. Spotty lacing down the glass as the beer was drank.",
                        Smell = "Roasted espresso coffee, oats, oatmeal, doughy, bready, some sweetness, and nutty.",
                        Taste = "Roastiness up front, nutty, oats, bready, chewy, doughy, some lactose sweetness, and light bitterness.",
                        Mouthfeel = "Smooth, chewy notes, roasted bitterness, medium bodied, and medium carbonation.",
                        Overall = "Got to admit that the toasted coffee compliments the nutty and oaty notes of this beer. Definitely could revisit this roasty brown ale."
                    }
                }
            }
        };

        public Beer GetBeer(int id)
        {
            Beer beerToReturn = null;

            foreach (var beer in _beers)
            {
                if (beer.Id == id)
                {
                    beerToReturn = beer;

                    break;
                }
            }

            return beerToReturn;
        }
    }
}