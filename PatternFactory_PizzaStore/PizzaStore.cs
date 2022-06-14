using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_PizzaStore
{
    abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }

        protected abstract Pizza createPizza(string type);
    }

    class NYPizzaStore : PizzaStore
    {
        public PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        protected override Pizza createPizza(string type) => type switch
        {
            "cheese" => new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" },
            "veggie" => new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" },
            _ => null
        };
    }
}
