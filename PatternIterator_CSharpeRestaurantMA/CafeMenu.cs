using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_CSharpeRestaurantMA
{
    class CafeMenu: IEnumerable<MenuItem>
    {
        Dictionary<string, MenuItem> menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            addItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
            addItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
            addItem("Burrito", "A large buritto, with whole pinto beans, salsa, guacamole", true, 4.29);
        }

        public void addItem(string name, string description, bool vegetarian, double price) => menuItems.Add(name, new MenuItem(name, description, vegetarian, price));

        public IEnumerator<MenuItem> GetEnumerator() => menuItems.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
