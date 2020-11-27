using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.ShoppingCart
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<string, double> _basicPrices;

        public Checkout()
        {
            _basicPrices = new Dictionary<string, double>
            {
                {"A", 50},
                {"B", 30},
                {"C", 20},
                {"D", 15},
            };
        }

        public double GetTotal(string items)
        {
            char[] knowProducts = new[] {'A', 'B', 'C', 'D'};
            var array = items.ToCharArray();
            double summ = 0;

            foreach (var charElement in array.Where(x => knowProducts.Contains(x)))
            {
                summ+= _basicPrices.FirstOrDefault(x => x.Key == charElement.ToString()).Value;
            }

            return summ;

        }
    }
}