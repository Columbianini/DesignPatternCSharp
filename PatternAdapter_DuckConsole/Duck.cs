using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter_DuckConsole
{
    interface Duck
    {
        void quack();
        void fly();
    }

    class MallardDuck : Duck
    {
        public void fly() => Console.WriteLine("I am flying");

        public void quack() => Console.WriteLine("Quack");
    }

    class TurkeyAdapter : Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey) => this.turkey = turkey;
        public void quack() => turkey.gobble();

        public void fly()
        {
            for(int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }
    }
}
