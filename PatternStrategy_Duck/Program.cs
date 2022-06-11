using System;

namespace PatternStrategy_Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mullard = new MullardDuck();
            mullard.performFly();
            mullard.performQuack();        
        }
    }
}
