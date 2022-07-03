using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProxy_GumballMachineServiceContract
{
    public interface State
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
        void refill();
    }

    public class SoldState : State
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine) => this.gumballMachine = gumballMachine;

        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.Count > 0)
                gumballMachine.State = gumballMachine.NoQuarterState;
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                gumballMachine.State = gumballMachine.SoldOutState;
            }

        }

        public void ejectQuarter() => Console.WriteLine("Sorry you already turned crank");

        public void insertQuarter() => Console.WriteLine("Please wait, we are ready giving you a gumball");

        public void refill() { }
        public void turnCrank() => Console.WriteLine("Turning twice cannot get you another gumball");
    }


    public class SoldOutState : State
    {
        private GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine) => this.gumballMachine = gumballMachine;

        public void dispense() => Console.WriteLine("No gumball dispensed");

        public void ejectQuarter() => Console.WriteLine("You can't eject. You haven't inserted a quarter yet");

        public void insertQuarter() => Console.WriteLine("You can't insert a quarter, the machine is sold out");

        public void turnCrank() => Console.WriteLine("You turned. But there is no gumballs");
        public void refill() => gumballMachine.State = gumballMachine.NoQuarterState;

    }

    public class HasQuarterState : State
    {
        private Random random = new Random(Environment.TickCount);
        private GumballMachine gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine) => this.gumballMachine = gumballMachine;
        public void dispense() => Console.WriteLine("You need to turn the crank");
        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.State = gumballMachine.NoQuarterState;
        }
        public void insertQuarter() => Console.WriteLine("You can't insert another quarter");

        public void refill() { }

        public void turnCrank()
        {
            if ((random.Next(10) == 0) & (gumballMachine.Count >= 2))
                gumballMachine.State = gumballMachine.WinnerState;
            else
                gumballMachine.State = gumballMachine.SoldState;
        }
    }

    public class NoQuarterState : State
    {
        private GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine) => this.gumballMachine = gumballMachine;
        public void dispense() => Console.WriteLine("You need to pay first");

        public void ejectQuarter() => Console.WriteLine("You have not inserted a quarter yet");

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.State = gumballMachine.HasQuarterState;
        }

        public void refill() { }

        public void turnCrank() => Console.WriteLine("You turned but there is no quarter");
    }

    public class WinnerState : State
    {
        private GumballMachine gumballMachine;
        public WinnerState(GumballMachine gumballMachine) => this.gumballMachine = gumballMachine;
        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.Count == 0)
            {
                Console.WriteLine("Oops, out of gumballs");
                gumballMachine.State = gumballMachine.SoldOutState;
            }
            else
            {
                gumballMachine.releaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got 2 gumballs for your quarter");
                if (gumballMachine.Count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs");
                    gumballMachine.State = gumballMachine.SoldOutState;
                }
                else
                {
                    gumballMachine.State = gumballMachine.NoQuarterState;
                }
                

            }
            
        }

        public void ejectQuarter() => Console.WriteLine("Sorry you already turned crank");

        public void insertQuarter() => Console.WriteLine("Please wait, we are ready giving you a gumball");

        public void refill() { }

        public void turnCrank() => Console.WriteLine("Turning twice cannot get you another gumball");
    }

}
