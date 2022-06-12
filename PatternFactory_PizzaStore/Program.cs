using System;

namespace PatternFactory_PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}");


        }
    }
}
