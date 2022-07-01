using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    class QuackCounter : Quackable
    {
        public static int NumberOfQuacks { get; set; } = 0;

        private Quackable duck;

        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
        }
        public void quack()
        {
            duck.quack();
            NumberOfQuacks++;
        }

        public void registerObserver(Observer observer) => duck.registerObserver(observer);

        public void notifyObservers() => duck.notifyObservers();
    }
}
