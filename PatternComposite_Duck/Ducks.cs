using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    class MallardDuck : Quackable
    {
        private Observable observable;

        public MallardDuck() => observable = new Observable(this);
        public void notifyObservers() => observable.notifyObservers();

        public void quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void registerObserver(Observer observer) => observable.registerObserver(observer);
    }

    class RedheadDuck : Quackable
    {
        private Observable observable;

        public RedheadDuck() => observable = new Observable(this);
        public void notifyObservers() => observable.notifyObservers();

        public void quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }

        public void registerObserver(Observer observer) => observable.registerObserver(observer);
    }

    class DuckCall : Quackable
    {
        private Observable observable;

        public DuckCall() => observable = new Observable(this);
        public void notifyObservers() => observable.notifyObservers();

        public void quack()
        {
            Console.WriteLine("kwak");
            notifyObservers();
        }

        public void registerObserver(Observer observer) => observable.registerObserver(observer);
    }

    class RubberDuck : Quackable
    {
        private Observable observable;

        public RubberDuck() => observable = new Observable(this);
        public void notifyObservers() => observable.notifyObservers();

        public void quack()
        {
            Console.WriteLine("Squeak");
            notifyObservers();
        }

        public void registerObserver(Observer observer) => observable.registerObserver(observer);
    }
}
