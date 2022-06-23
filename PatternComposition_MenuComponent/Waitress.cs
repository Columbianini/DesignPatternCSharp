using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposition_MenuComponent
{
    class Waitress
    {
       private MenuComponent menuComponents;

        public Waitress(MenuComponent menuComponents)
        {
            this.menuComponents = menuComponents;    
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
            printMenu(menuComponents.getChild(0));
            Console.WriteLine("\nLUNCH");
            printMenu(menuComponents.getChild(1));
            Console.WriteLine("\nDinner" +
                "");
            printMenu(menuComponents.getChild(2));
        }

        private void printMenu(MenuComponent menu) => menu.print();
    }
}
