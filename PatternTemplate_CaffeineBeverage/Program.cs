using System;

namespace PatternTemplate_CaffeineBeverage
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaHook.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeWithHook.prepareRecipe();
        }
    }
}
