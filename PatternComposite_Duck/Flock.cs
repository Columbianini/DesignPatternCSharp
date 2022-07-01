using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    class Flock : Quackable
    {
        private List<Quackable> quackers = new List<Quackable>();

        public void add(Quackable duck)
        {
            quackers.Add(duck);
        }

        public void notifyObservers() { }

        public void quack()
        {
            foreach(var quacker in quackers)
            {
                quacker.quack();
            }
        }

        public void registerObserver(Observer observer)
        {
            foreach(var duck in quackers)
            {
                duck.registerObserver(observer);
            }
        }
    }
}
