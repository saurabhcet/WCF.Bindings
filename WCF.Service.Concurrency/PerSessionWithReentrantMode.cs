using System;
using System.ServiceModel;
using System.Threading;

namespace WCF.Service.Concurrency
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PerSessionWithReentrantMode" in both code and config file together.
    public class PerSessionWithReentrantMode : IPerSessionWithReentrantMode
    {
        public int instance;
        public string Get(string client)
        {
            // increment instance count
            instance++;
            var response = $"Client Name:{client} Instance:{instance} Thread:{Thread.CurrentThread.ManagedThreadId} Time:{DateTime.Now}";
            Console.WriteLine(response);

            Thread.Sleep(5000);

            return response;
        }
    }
}
