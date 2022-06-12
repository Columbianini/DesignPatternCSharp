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
        protected override Pizza createPizza(string type) => type switch
        {
            "cheese" => new NYStyleCheesePizza(),
            _ => throw new NotImplementedException(),
        };
    }

    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type) => type switch
        {
            "cheese" => new ChicagoStyleCheesePizza(),
            _ => throw new NotImplementedException(),
        };
    }
}
