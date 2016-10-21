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
                Id = 1,
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
                        Appearance = "A one finger off white head was poured that reduced to a thin layer. It is an amber brown color with no vision of anything. Spotty lacing down the glass as the beer was drank.",
                        Smell = "Roasted espresso coffee, oats, oatmeal, doughy, bready, some sweetness, and nutty.",
                        Taste = "Roastiness up front, nutty, oats, bready, chewy, doughy, some lactose sweetness, and light bitterness.",
                        Mouthfeel = "Smooth, chewy notes, roasted bitterness, medium bodied, and medium carbonation.",
                        Overall = "Got to admit that the toasted coffee compliments the nutty and oaty notes of this beer. Definitely could revisit this roasty brown ale."
                    }
                }
            },
            new Beer()
            {
                Id = 2,
                BeerName = "Chocolate Sombrero",
                Brewery = "Clown Shoes",
                BreweryLocation = "Massachusetts, United States",
                Style = "American Double / Imperial Stout",
                ABV = 9,
                DescriptionHtml = "<p><strong>Chocolate Sombrero</strong> Roasted dark malts plus extra chocolate malts plus ancho chile plus cinnamon plus organic vanilla extract plus a chocolate eating, beer drinking, Clown Shoes wearing, multi limbed, gorgeous and glorious Mexican wrestler on the label. That’s the recipe for a Chocolate Sombrero!</p>",
                Availability = "Year-round",
                BeerAttributes = new Attributes[]
                {
                    new Attributes() {
                        Appearance = "Poured into a snifter to a black beer topped by a finger of dense light tan head that fades quickly to a collar around the edge of the glass with some lacing.",
                        Smell = "Smells of chocolate, vanilla and some spices with a little roasted malt.",
                        Taste = "Taste is chocolate and some cinnamon with a little vanilla and some heat and spice from the peppers. There's a littel roast going on but it's like Mexican hot chocolate. Swallow is roasted malts, vanilla, cinnamon and some slight peppery heat.",
                        Mouthfeel = "This beer is fairly full in body with a silky mouthfeel. Carbonation is low but adequate and the finish is on the dry side.",
                        Overall = "Overall this is a really nice beer with good flavors and complexity. The adjuncts are a nice twist on the style but Xocoveza from stone is just a little bit better in my opinion. It's still well made and one to try if Xocoveza isn't around."
                    }
                }
            },
            new Beer()
            {
                Id = 3,
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