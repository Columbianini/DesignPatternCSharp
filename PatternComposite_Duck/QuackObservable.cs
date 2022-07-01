using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    interface QuackObservable
    {
        void registerObserver(Observer observer);
        void notifyObservers();
    }

    class Observable : QuackObservable
    {
        private List<Observer> observers = new List<Observer>();
        private QuackObservable duck;

        public Observable(QuackObservable duck) => this.duck = duck;


        public void notifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.update(duck);
            }
        }

        public void registerObserver(Observer observer) => observers.Add(observer);
    }
}
