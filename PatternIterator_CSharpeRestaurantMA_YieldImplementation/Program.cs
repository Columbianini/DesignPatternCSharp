using System;

namespace PatternIterator_CSharpeRestaurantMA_YieldImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.printMenu();
        }
    }
}
