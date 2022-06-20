using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplate_CaffeineBeverage
{
    abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        public abstract void addCondiments();
        

        private void pourInCup() => Console.WriteLine("Pouring into cup");

        public abstract void brew();
     

        public void boilWater() => Console.WriteLine("Boling Water");
    }


    class Coffee : CaffeineBeverage
    {
        public override void addCondiments() => Console.WriteLine("Adding Sugar and Milk");
        

        public override void brew() => Console.WriteLine("Dripping Coffee through filter");
    }


    class Tea : CaffeineBeverage
    {
        public override void addCondiments() => Console.WriteLine("Adding Lemon");


        public override void brew() => Console.WriteLine("Steeping the tea");
    }
}
