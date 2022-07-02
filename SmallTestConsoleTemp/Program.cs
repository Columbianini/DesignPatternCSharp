using System;

namespace SmallTestConsoleTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            BeatController controller = new BeatController();
            Console.WriteLine($"controller status: {controller.Status}");
        }
    }
}
