using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_RestaurantMA
{
    class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            Iterator dinerMenuIterator = dinerMenu.CreateIterator();

            Console.WriteLine("Menu\n----\nBREAKFAST");
            printMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            printMenu(dinerMenuIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                var menuItem = iterator.Next();
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price}--{menuItem.Description}");
            }
        }
    }
}
