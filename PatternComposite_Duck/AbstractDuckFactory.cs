using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    abstract class AbstractDuckFactory
    {
        public abstract Quackable createMallardDuck();
        public abstract Quackable createRedheadDuck();
        public abstract Quackable createDuckCall();
        public abstract Quackable createRubberDuck();
    }


    class DuckFactory : AbstractDuckFactory
    {
        public override Quackable createDuckCall() => new DuckCall();

        public override Quackable createMallardDuck() => new MallardDuck();

        public override Quackable createRedheadDuck() => new RedheadDuck();

        public override Quackable createRubberDuck() => new RubberDuck();
    }

    class DuckCountingFactory : AbstractDuckFactory
    {
        public override Quackable createDuckCall() => new QuackCounter(new DuckCall());
        public override Quackable createMallardDuck() => new QuackCounter(new MallardDuck());

        public override Quackable createRedheadDuck() => new QuackCounter(new RedheadDuck());

        public override Quackable createRubberDuck() => new QuackCounter(new RubberDuck());
    }
}
