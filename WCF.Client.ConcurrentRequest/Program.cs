using System;

namespace WCF.Client.ConcurrentRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Single Instance           
            //SingleInstanceWithSingleMode.SingleInstanceWithSingleModeClient client1 = new SingleInstanceWithSingleMode.SingleInstanceWithSingleModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    var result = client1.Get("SingleInstanceWithSingleMode");
            //    Console.WriteLine(result);
            //}

            //SingleInstanceWithConcurrentMode.SingleInstanceWithConcurrentModeClient client2 = new SingleInstanceWithConcurrentMode.SingleInstanceWithConcurrentModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    var result = client2.Get("SingleInstanceWithConcurrentMode");
            //    Console.WriteLine(result);
            //}

            //SingleInstanceWithReentrantMode.SingleInstanceWithReentrantModeClient client3 = new SingleInstanceWithReentrantMode.SingleInstanceWithReentrantModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    var result = client3.Get("SingleInstanceWithReentrantMode");
            //    Console.WriteLine(result);
            //}


            ////Per Session
            //PerSessionWithSingleMode.PerSessionWithSingleModeClient client4 = new PerSessionWithSingleMode.PerSessionWithSingleModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    var result = client4.Get("PerSessionWithSingleMode");
            //    Console.WriteLine(result);
            //}

            //PerSessionWithConcurrentMode.PerSessionWithConcurrentModeClient client5 = new PerSessionWithConcurrentMode.PerSessionWithConcurrentModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    var result = client5.Get("PerSessionWithConcurrentMode");
            //    Console.WriteLine(result);
            //}

            //PerSessionWithReentrantMode.PerSessionWithReentrantModeClient client6 = new PerSessionWithReentrantMode.PerSessionWithReentrantModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    var result = client6.Get("PerSessionWithReentrantMode");
            //    Console.WriteLine(result);
            //}


            //PerCall
            //PerCallWithSingleMode.PerCallWithSingleModeClient client7 = new PerCallWithSingleMode.PerCallWithSingleModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    client7.Get("PerCallWithSingleMode");
            //    //Console.WriteLine(result);
            //}

            PerCallWithConcurrentMode.PerCallWithConcurrentModeClient client8 = new PerCallWithConcurrentMode.PerCallWithConcurrentModeClient();
            for (int i = 0; i < 5; i++)
            {
                //var result = 
                    client8.Get("PerCallWithConcurrentMode");
                Console.WriteLine(DateTime.Now);
            }

            //PerCallWithReentrantMode.PerCallWithReentrantModeClient client9 = new PerCallWithReentrantMode.PerCallWithReentrantModeClient();
            //for (int i = 0; i < 5; i++)
            //{
            //    client9.Get("PerCallWithReentrantMode");
            //    //Console.WriteLine(result);
            //}

            Console.ReadLine();
        }
    }
}
