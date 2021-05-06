using System;
using System.ServiceModel;
using System.Threading;

namespace WCF.Service.Concurrency
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Single)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class SingleInstanceWithSingleMode : ISingleInstanceWithSingleMode
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
        //public string GetPerCallInstanceWithMultipleConcurreny(string client)
        //{
        //    int i=0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetPerCallInstanceWithReentrantConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetPerCallInstanceWithSingleConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetPerSessionInstanceWithMultipleConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetPerSessionInstanceWithReentrantConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetPerSessionInstanceWithSingleConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetSingleInstanceWithMultipleConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetSingleInstanceWithReentrantConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}

        //public string GetSingleInstanceWithSingleConcurreny(string client)
        //{
        //    int i = 0;
        //    return InstanceManagement(client, i);
        //}


        //private string InstanceManagement(string client, int instance)
        //{
        //    // increment instance count
        //    instance++;
        //    var response = $"Client:{client}, Instance:{instance}, Thread:{Thread.CurrentThread.ManagedThreadId} Time:{DateTime.Now}";
        //    Console.WriteLine(response);

        //    Thread.Sleep(5000);

        //    return response;
        //}
    }
}
