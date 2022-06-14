using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory_PizzaStore
{
    interface Dough
    {
       string Name { get; }
    }

    class ThinCrustDough : Dough
    {
        public string Name => "Thin Crust Dough";
    }

    class ThickCrustDough : Dough
    {
        public string Name => "Thick Crust Dough";
    }

    interface Sauce
    {
        string Name { get; }
    }

    class MarinaraSauce : Sauce
    {
        public  string Name => "Marinara Sauce";
    }

    class PlumTomatoSauce : Sauce
    {
        public string Name => "Plum Tomato Sauce";
    }

    interface Cheese
    {
        string Name { get; }
    }

    class MozzarellaCheese : Cheese
    {
        public string Name => "Mozzarella Cheese";
    }

    class ReggianoCheese : Cheese
    {
        public string Name => "Reggiano Cheese";
    }

    interface Veggie
    {
        string Name { get; }
    }

    class Garlic : Veggie
    {
        public string Name => "Garlic";
    }

    class Onion : Veggie
    {
        public string Name => "Onion";
    }

    class Mushroom : Veggie
    {
        public string Name => "Mushroom";
    }

    class RedPepper : Veggie
    {
        public string Name => "Red Pepper";
    }

    class EggPlant : Veggie
    {
        public string Name => "Egg Plant";
    }

    class Spinach : Veggie
    {
        public string Name => "Spinach";
    }

    class BlackOlives : Veggie
    {
        public string Name => "Black Olives";
    }

    interface Pepperoni
    {
        string Name { get; }
    }

    class SlicedPepperoni : Pepperoni
    {
        public string Name => "Sliced Pepperoni";
    }

    interface Clams
    {
        string Name { get; }
    }

    class FrozenClams : Clams
    {
        public string Name => "Frozen Clams";
    }

    class FreshClams : Clams
    {
        public string Name => "Fresh Clams";
    }
}
