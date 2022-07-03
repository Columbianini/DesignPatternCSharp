using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PatternProxy_Client.GumballMachineProxyReference;

namespace PatternProxy_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GumballMachineTrackerClient();
            Console.WriteLine($"Gumball Machine: {client.GetLocation()}");
            Console.WriteLine($"Current Inventory: {client.GetCount()}");
            Console.WriteLine($"Current state: {client.GetState()}");
            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}
