using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_CSharpeRestaurantMA_YieldImplementation
{
    class PancakeHouseMenu: IEnumerable<string>
    {
        public List<MenuItem> MenuItems { get; private set; }

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>();
            addItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            addItem("Regular Pancake Breakfast", "Pancakes wtih fried eggs, sausage", false, 2.99);
            addItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            addItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }

        //public Iterator CreateIterator() => new PancakeHouseMenuIterator(MenuItems);

        public IEnumerator<string> GetEnumerator()
        {
            foreach(var item in MenuItems)
                yield return $"{item.Name}, {item.Price}--{item.Description}";
        }

        public void addItem(string name, string description, bool vegetarian, double price) => MenuItems.Add(new MenuItem(name, description, vegetarian, price));


        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
