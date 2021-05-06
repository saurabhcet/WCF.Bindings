using System;
using System.ServiceModel;
using WCF.Service.Account;
using WCF.Service.Loan;

namespace WCF.Host.Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Balance)))
            {
                host.Open();
                Console.WriteLine("Account Service Host started");                
            };

            using (ServiceHost host = new ServiceHost(typeof(EMI)))
            {
                host.Open();
                Console.WriteLine("Loan Service Host started");
            };
            Console.ReadLine();
        }
    }
}
