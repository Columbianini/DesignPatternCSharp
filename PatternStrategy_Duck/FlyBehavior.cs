using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_Duck
{
    interface IFlyBehavior
    {
        void fly();
    }


    public class FlyWithWings : IFlyBehavior
    {
        public void fly() => Console.WriteLine("I am flying with wings");
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void fly() => Console.WriteLine("I cannot fly");
    }
}
