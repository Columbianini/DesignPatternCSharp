using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_CSharpeRestaurantMA_YieldImplementation
{
    class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool vegetarian { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, string description, bool vegatarian, double price)
        {
            Name = name;
            Description = description;
            vegatarian = vegetarian;
            Price = price;
        }
    }
}
