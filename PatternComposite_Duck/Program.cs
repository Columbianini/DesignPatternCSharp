using System;

namespace PatternComposite_Duck
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator ducksimulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new DuckCountingFactory();
            ducksimulator.simulate(duckFactory);
        }

        private void simulate(AbstractDuckFactory duckFactory)
        {
            Quackable redheadDuck = duckFactory.createRedheadDuck();
            Quackable duckCall = duckFactory.createDuckCall();
            Quackable rubberDuck = duckFactory.createRubberDuck();
            Quackable gooseAdapter = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator: With Composite - Flocks");

            Flock flockOfDucks = new Flock();
            flockOfDucks.add(redheadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(gooseAdapter);

            Flock flockOfMallards = new Flock();
            Quackable mallardOne = duckFactory.createMallardDuck();
            Quackable mallardTwo = duckFactory.createMallardDuck();
            Quackable mallardThree = duckFactory.createMallardDuck();
            Quackable mallardFour = duckFactory.createMallardDuck();
            flockOfMallards.add(mallardOne);
            flockOfMallards.add(mallardTwo);
            flockOfMallards.add(mallardThree);
            flockOfMallards.add(mallardFour);

            flockOfDucks.add(flockOfMallards); // You could add Composition to Composition!!!!!!!!!!!!!

            Quackologist quackologist = new Quackologist();
            flockOfDucks.registerObserver(quackologist);


            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            simulate(flockOfDucks);
            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            simulate(flockOfMallards);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        private void simulate(Quackable duck)
        {
            duck.quack();
        }
    }
}
