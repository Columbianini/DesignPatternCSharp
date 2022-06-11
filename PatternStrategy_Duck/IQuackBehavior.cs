using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy_Duck
{
    interface IQuackBehavior
    {
        void quack();
    }

    public class Quack : IQuackBehavior
    {
        public void quack() => Console.WriteLine("Quack");
    }

    public class MuteQuack : IQuackBehavior
    {
        public void quack() => Console.WriteLine("<< Silence >>");
    }

    public class Squeak : IQuackBehavior
    {
        public void quack() => Console.WriteLine("Squeak");
    }
}
