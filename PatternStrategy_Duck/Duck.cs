using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_Duck
{
    abstract class Duck
    {
        public IFlyBehavior flyBehavior;

        public IQuackBehavior quackBehavior;

        public virtual void swim() => Console.WriteLine("All ducks float, even decoys");

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }
    }

    class MullardDuck : Duck
    {
        public MullardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display() => Console.WriteLine("I am Mullard Duck");
    }

}
