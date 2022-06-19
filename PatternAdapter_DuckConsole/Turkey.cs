using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter_DuckConsole
{
    interface Turkey
    {
        void gobble();
        void fly();
    }

    class WildTurkey : Turkey
    {
        public void fly() => Console.WriteLine("I am flying a short distance");

        public void gobble() => Console.WriteLine("Gobble gobble");
    }
}
