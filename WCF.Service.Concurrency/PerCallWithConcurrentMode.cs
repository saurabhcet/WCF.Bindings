using System;
using System.ServiceModel;
using System.Threading;

namespace WCF.Service.Concurrency
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class PerCallWithConcurrentMode : IPerCallWithConcurrentMode
    {
        public int instance;
        public void Get(string client)
        {
            // increment instance count
            instance++;
            var response = $"Client Name:{client} Instance:{instance} Thread:{Thread.CurrentThread.ManagedThreadId} Time:{DateTime.Now}";
            Console.WriteLine(response);

            Thread.Sleep(5000);

            //return response;
        }
    }
}
