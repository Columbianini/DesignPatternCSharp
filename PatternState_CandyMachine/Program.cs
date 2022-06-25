using System;

namespace PatternState_CandyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleGumballMachine gumballMachine = new SimpleGumballMachine(5);

            //Console.WriteLine(gumballMachine);

            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();

            //Console.WriteLine(gumballMachine);

            //gumballMachine.insertQuarter();
            //gumballMachine.ejectQuarter();
            //gumballMachine.turnCrank();

            //Console.WriteLine(gumballMachine);

            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();
            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();
            //gumballMachine.ejectQuarter();

            //Console.WriteLine(gumballMachine);

            //gumballMachine.insertQuarter();
            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();
            //gumballMachine.insertQuarter();
            //gumballMachine.turnCrank();
            //gumballMachine.insertQuarter(); // SOLD OUT ALREADY
            //gumballMachine.turnCrank();

            //Console.WriteLine(gumballMachine);

            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
