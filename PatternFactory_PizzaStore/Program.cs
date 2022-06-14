using System;

namespace PatternFactory_PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaStore nyStore = new NYPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");
        }
    }
}
