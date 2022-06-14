using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_PizzaStore
{
    interface PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        List<Veggie> createVeggies();
        Pepperoni createPepperoni();
        Clams createClam();
    }

    class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese() => new ReggianoCheese();

        public Clams createClam() => new FreshClams();

        public Dough createDough() => new ThinCrustDough();

        public Pepperoni createPepperoni() => new SlicedPepperoni();

        public Sauce createSauce() => new MarinaraSauce();
        public List<Veggie> createVeggies() => new List<Veggie>() { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }
}
