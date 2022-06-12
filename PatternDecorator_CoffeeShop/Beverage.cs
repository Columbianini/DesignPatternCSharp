using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator_CoffeeShop
{
    abstract class Beverage
    {
        public Size size { get; set; } = Size.TALL;
        public abstract string description { get; }

        public abstract double cost();
    }

    abstract class CondimentDecorator: Beverage
    {
        public Beverage beverage { get; set; }
    }

    class Espresso : Beverage
    {
        public override string description => "Espresso";

        public override double cost() => 1.99F;
    }

    class HouseBlend: Beverage
    {
        public override string description => "House Blend Coffee";

        public override double cost() => 0.89F;
    }

    class DarkRoast: Beverage
    {
        public override string description => "Dark Roast Coffee";

        public override double cost() => 0.99F;
    }

    class Decaf : Beverage
    {
        public override string description => "Decaf Coffee";

        public override double cost() => 1.05F;
    }

    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string description => beverage.description + ", Mocha"; 

        public override double cost() => 0.20F + beverage.cost();
    }

    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string description => beverage.description + ", Milk";

        public override double cost() => 0.10F + beverage.cost();
    }

    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string description => beverage.description + ", Soy";

        public override double cost() => beverage.size switch
        {
            Size.TALL => 0.10F + beverage.cost(),
            Size.GRANDE => 0.15F + beverage.cost(),
            Size.VENTI => 0.20F + beverage.cost(),
            _ => throw new NotImplementedException(),
        };
    }

    class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string description => beverage.description + ", Whip";

        public override double cost() => 0.10F + beverage.cost();
    }
}
