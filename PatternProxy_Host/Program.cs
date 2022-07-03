using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PatternProxy_GumballMachineServiceContract;
using System.ServiceModel.Description;

namespace PatternProxy_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/PatternProxy_GumballMachineServiceContract/");
            var selfHost = new ServiceHost(typeof(GumballMachine), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IGumballMachineTracker), new WSHttpBinding(), "GumballMachine");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5: Start the service.
                selfHost.Open();
                Console.WriteLine("The service is ready.");

                // Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }           
    }
}
