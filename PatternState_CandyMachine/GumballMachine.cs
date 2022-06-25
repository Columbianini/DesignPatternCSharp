using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_CandyMachine
{
    class GumballMachine
    {
        public const int SOLD_OUT = 0;
        public const int NO_QUARTER = 1;
        public const int HAS_QUARTER = 2;
        public const int SOLD = 3;

        private int state = SOLD;
        private int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
                state = NO_QUARTER;
        }

        public void insertQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("You cannot insert another quarter");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You inserted a quarter");
                    state = HAS_QUARTER;
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You cannot insert a quarter, the machine is sold out");
                    break;
                case SOLD:
                    Console.WriteLine("Please wait, we're already giving you a gumble");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }


        public void ejectQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("Quarter returned");
                    state = NO_QUARTER;
                    break;
                case NO_QUARTER:
                case SOLD_OUT:
                    Console.WriteLine("You have not inserted a quarter");
                    break;
                case SOLD:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void turnCrank()
        {
            switch (state)
            {
                case NO_QUARTER:
                    Console.WriteLine("You turned but there is no quarter");
                    break;
                case HAS_QUARTER:
                    Console.WriteLine("You turned ...");
                    state = SOLD;
                    dispense();
                    break;
                case SOLD:
                    Console.WriteLine("Turning twice does not get you another gumball");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You turned but there's no quarter");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void dispense()
        {
            switch (state)
            {
                case SOLD:
                    Console.WriteLine("A gumball comes rolling out the slot");
                    count--;
                    state = count == 0 ? SOLD_OUT : NO_QUARTER;
                    break;
                case SOLD_OUT:
                    Console.WriteLine("No gumball dispensed");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You need to pay first");
                    break;
                case HAS_QUARTER:
                    Console.WriteLine("You need to turn the crank");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            string output = $"Might Gumball, Inc\nJava-enabled Standing Gumball Model #2004\nInventory: {count} gumnballs\n";


            switch (state)
            {
                case SOLD_OUT:
                    output += "Machine is sold out\n";
                    break;
                case SOLD:
                    output += "Machine is dispensing\n";
                    break;
                case HAS_QUARTER:
                    output += "Machine is waiting for turning the crank or ejecting the quarter\n";
                    break;
                case NO_QUARTER:
                    output += "Machine is waiting for quarter\n";
                    break;
                default:
                    throw new NotImplementedException();
            }
            return output;
        }


    }
}
