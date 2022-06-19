using System;

namespace PatternAdapter_DuckConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // QA On Duck and Turkey
            Duck duck = new MallardDuck();

            Turkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says ...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("\nThe Duck says ...");
            testDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says ...");
            testDuck(turkeyAdapter);

        }

        static void testDuck(Duck duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}
