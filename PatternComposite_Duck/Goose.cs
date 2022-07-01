using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    class Goose
    {
        public void honk()
        {
            Console.WriteLine("Honk");
        }
    }

    class GooseAdapter: Quackable
    {
        private Observable observable;
        private Goose goose;
        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            this.observable = new Observable(this);
        }

        public void notifyObservers() => observable.notifyObservers();

        public void quack()
        {
            goose.honk();
            notifyObservers();
        }

        public void registerObserver(Observer observer) => observable.registerObserver(observer);
    }
}
