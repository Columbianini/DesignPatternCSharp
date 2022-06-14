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
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }

        public Cheese Cheese { get; set; }

        public Clams Clams { get; set; }
        //public List<string> Toppings { get; set; } = new List<string>();

        public abstract void prepare();

        public void bake() => Console.WriteLine("Bake for 25 minutes at 350");

        public virtual void cut() => Console.WriteLine("Cutting the pizza into diagnonal slices");

        public void box() => Console.WriteLine("Place pizza in official PizzaStore box");
    }

    class CheesePizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.createDough();
            Sauce = ingredientFactory.createSauce();
            Cheese = ingredientFactory.createCheese();
        }

    }

    class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.createDough();
            Sauce = ingredientFactory.createSauce();
            Cheese = ingredientFactory.createCheese();
            Clams = ingredientFactory.createClam();
        }
    }

    //class ChicagoStyleCheesePizza: Pizza
    //{
    //    public ChicagoStyleCheesePizza()
    //    {
    //        Name = "Chicago Style Deep Dish Cheese Pizza";
    //        Dough = "Extra Thick Crust Dough";
    //        Sauce = "Plum Tomato Sauce";
    //        Toppings.Add("Shredded Mozzarella Cheese");
    //    }
    //    public override void cut() => Console.WriteLine("Cutting the pizza into square slices");
    //}

    //class NYStyleCheesePizza: Pizza
    //{

    //    public NYStyleCheesePizza()
    //    {
    //        Name = "NY Style Sauce and Cheese Pizza";
    //        Dough = "Thin Crust Dough";
    //        Sauce = "Marinara Sauce";
    //        Toppings.Add("Grated Reggiano Cheese");
    //    }
    //}

}
