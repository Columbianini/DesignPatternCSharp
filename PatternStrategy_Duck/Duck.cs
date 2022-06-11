using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_Duck
{
    abstract class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }

        public IQuackBehavior quackBehavior { get; set; }

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

    class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display() => Console.WriteLine("I am a model duck");
    }

}
