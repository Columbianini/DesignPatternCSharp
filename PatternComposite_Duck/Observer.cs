using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    interface Observer
    {
        void update(QuackObservable duck);
    }

    class Quackologist : Observer
    {
        public void update(QuackObservable duck) => Console.WriteLine($"Quackologist: {duck} just quacked");
    }


}
