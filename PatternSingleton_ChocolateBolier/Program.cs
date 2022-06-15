using System;

namespace PatternSingleton_ChocolateBolier
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolate = ChocolateBoiler.getInstance();
            chocolate.fill();
            Console.WriteLine($"chocolateBoilder's status —— Empty: {chocolate.empty} boiled: {chocolate.boiled}");
            ChocolateBoiler chocolate11 = ChocolateBoiler.getInstance();
            Console.WriteLine($"Fetch the chocolateBoilder11's status again —— Empty: {chocolate.empty} boiled: {chocolate.boiled}");

            ChocolateBoiler2 chocolate2 = ChocolateBoiler2.getInstance();
            chocolate2.fill();
            chocolate2.boil();
            Console.WriteLine($"chocolateBoilder2's status —— Empty: {chocolate2.empty} boiled: {chocolate2.boiled}");
            ChocolateBoiler2 chocolate22 = ChocolateBoiler2.getInstance();
            Console.WriteLine($"Fetch the chocolateBoilder22's status again —— Empty: {chocolate2.empty} boiled: {chocolate2.boiled}");
        }
    }
}
