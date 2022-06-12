using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_PizzaStore
{
    abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public void prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in Toppings)
            {
                Console.WriteLine($"   {topping}");
            }
        }

        public void bake() => Console.WriteLine("Bake for 25 minutes at 350");

        public virtual void cut() => Console.WriteLine("Cutting the pizza into diagnonal slices");

        public void box() => Console.WriteLine("Place pizza in official PizzaStore box");
    }

    class ChicagoStyleCheesePizza: Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
        }
        public override void cut() => Console.WriteLine("Cutting the pizza into square slices");
    }

    class NYStyleCheesePizza: Pizza
    {

        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }

}
