using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite_Duck
{
    interface Quackable:QuackObservable
    {
        void quack();
    }
}
