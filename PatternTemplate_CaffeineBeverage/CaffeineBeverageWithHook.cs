using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTemplate_CaffeineBeverage
{
    abstract class CaffeineBeverageWithHook
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            } 
        }

        public virtual bool customerWantsCondiments() => true;

        public abstract void addCondiments();
        

        private void pourInCup() => Console.WriteLine("Pouring into cup");

        public abstract void brew();
     

        public void boilWater() => Console.WriteLine("Boling Water");
    }


    class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void addCondiments() => Console.WriteLine("Adding Sugar and Milk");
        

        public override void brew() => Console.WriteLine("Dripping Coffee through filter");

        public override bool customerWantsCondiments()
        {
            string answer = getUserInput();

            return answer.ToLower().StartsWith("y")
                ;
        }

        private string getUserInput()
        {
            string? answer = null;
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                answer = Console.ReadLine();
            }
            catch(IOException e)
            {
                Console.WriteLine("IO error trying to read your answer");
            }
            if (answer == null)
                return "no";
            return answer;
        }
    }


    class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void addCondiments() => Console.WriteLine("Adding Lemon");


        public override void brew() => Console.WriteLine("Steeping the tea");
    }
}
