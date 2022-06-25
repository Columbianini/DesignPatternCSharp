using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState_CandyMachine
{
    class GumballMachine
    {
        //public static Random Random = new Random();
        public State SoldOutState { get; set; }
        public State SoldState { get; set; }
        public State WinnerState { get; set; }
        public State HasQuarterState { get; set; }
        public State NoQuarterState { get; set; }

        public State State { get; set; }

        public int Count { get; set; }

        public GumballMachine(int count)
        {
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);
            HasQuarterState = new HasQuarterState(this);
            NoQuarterState = new NoQuarterState(this);
            SoldState = new SoldState(this);
            Count = count;
            if (Count >= 2)
                State = NoQuarterState;
            else
                State = SoldOutState;
        }

        public void insertQuarter() => State.insertQuarter();

        public void ejectQuarter() => State.ejectQuarter();

        public void turnCrank()
        {
            State.turnCrank();
            State.dispense();
        }

        public void dispense() => State.dispense();

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count > 0)
                Count--;
        }

        public void refill(int count)
        {
            Count += count;
            Console.WriteLine($"The gumball machine was just refilled; its new count is {Count}");
            State.refill();
        }


        public override string ToString()
        {
            string output = $"\nMight Gumball, Inc\nJava-enabled Standing Gumball Model #2004\nInventory: {Count} gumnballs\n";

            if (State == SoldOutState)
                output += "Machine is sold out\n";
            else if (State == SoldState)
                output += "Machine is dispensing\n";
            else if (State == HasQuarterState)
                output += "Machine is waiting for turning the crank or ejecting the quarter\n";
            else if (State == NoQuarterState)
                output += "Machine is waiting for quarter\n";
            else
                throw new NotImplementedException();

            return output;
        }
    }
}
