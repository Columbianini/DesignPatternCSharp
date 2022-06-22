using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_CSharpeRestaurantMA
{
    class DinerMenu: IEnumerable<MenuItem>
    {
        public const int MAX_TIMES = 6;
        private int numberofItems = 0;
        public MenuItem[] MenuItems { get; private set; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_TIMES];
            addItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            addItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            addItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            addItem("Hotdog", "A hot dog with sauerkraut, relish, onions, topped with cheese", false, 3.05);
        }

        //public Iterator CreateIterator() => new DinerMenuIterator(MenuItems);
        public IEnumerator<MenuItem> GetEnumerator() => new DinerMenuIterator(MenuItems);

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            if (numberofItems >= MAX_TIMES)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                MenuItems[numberofItems] = new MenuItem(name, description, vegetarian, price);
                numberofItems++;
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
