using System.Collections.Generic;
using Kata.ShoppingCart.Models;

namespace Kata.ShoppingCart
{
    public class DiscauntApplyer
    {
        private readonly List<Discaunt> _discaunts;

        public DiscauntApplyer()
        {
            _discaunts = new List<Discaunt>
            {
                new Discaunt{Product = "A", Count = 3, Price = 130},
                new Discaunt{Product = "B", Count = 2, Price = 45},
            };
        }
        public (string elements, double colculated) FindDiscaunt(string elements)
        {
            
            return (elements, 0);
        }
    }
}