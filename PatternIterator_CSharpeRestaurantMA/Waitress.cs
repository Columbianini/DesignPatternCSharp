using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_CSharpeRestaurantMA
{
    class Waitress
    {
        IEnumerable<MenuItem> pancakeHouseMenu;
        IEnumerable<MenuItem> dinerMenu;
        IEnumerable<MenuItem> cafeMenu;

        public Waitress(IEnumerable<MenuItem> pancakeHouseMenu, IEnumerable<MenuItem> dinerMenu, IEnumerable<MenuItem> cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void printMenu()
        {
            //var pancakeIterator = pancakeHouseMenu.GetEnumerator();
            //var dinerMenuIterator = dinerMenu.GetEnumerator();

            //Console.WriteLine("Menu\n----\nBREAKFAST");
            //printMenu(pancakeIterator);
            //Console.WriteLine("\nLUNCH");
            //printMenu(dinerMenuIterator);
            Console.WriteLine("Menu\n----\nBREAKFAST");
            printMenu(pancakeHouseMenu);
            Console.WriteLine("\nLUNCH");
            printMenu(dinerMenu);
            Console.WriteLine("\nDinner");
            printMenu(cafeMenu);
        }

        private void printMenu(IEnumerable<MenuItem> menu)
        {
            //while (iterator.MoveNext())
            //{
            //    var menuItem = iterator.Current;
            //    Console.WriteLine($"{menuItem.Name}, {menuItem.Price}--{menuItem.Description}");
            //}
            foreach(var menuItem in menu) 
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price}--{menuItem.Description}");
        }
    }
}
