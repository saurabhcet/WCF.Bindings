using System;
using System.ServiceModel;
using WCF.Service.Concurrency;

namespace WCF.Host.Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(SingleInstanceWithSingleMode)))
            {
                host.Open();
                Console.WriteLine("Instance Management Host service started");
            }
            Console.ReadLine();
        }
    }
}
