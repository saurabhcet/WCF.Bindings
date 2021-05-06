using System;
using System.Transactions;

namespace WCF.Client.Transaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your EMI amount:");           
            int emiAmount = Convert.ToInt32(Console.ReadLine());
            Balance.User user = new Balance.User { UserName = "SAURABH" };

            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {                     
                    Balance.BalanceClient balanceClient = new Balance.BalanceClient();
                    var accDetail = balanceClient.AccountDetails(user);
                    Console.WriteLine($"Before EMI: UserName: {user.UserName}, Account Balance: {accDetail.Balance}");

                    var userAccount = balanceClient.Debit(user, emiAmount);

                    EMI.EMIClient emiClient = new EMI.EMIClient();
                    EMI.User emiUser = new EMI.User { UserId = accDetail.UserId, UserName = user.UserName };
                    var userTransaction = emiClient.PaymentStatus(emiUser, emiAmount);

                    ts.Complete();

                    string paymentStatus = userTransaction.PaymentStatus ? "Successful": "Failed";
                    Console.WriteLine($"EMI amount: {emiAmount}, New Account Balance: {userAccount.Balance}, Payment Status: {paymentStatus}");
                }
                catch(Exception e)
                {
                    ts.Dispose();
                    Console.WriteLine(e.Message);
                }              
            }

            Balance.BalanceClient client = new Balance.BalanceClient();
            var accountDetails = client.AccountDetails(user);
            Console.WriteLine($"After EMI: UserName: {user.UserName}, Account Balance: {accountDetails.Balance}");

            Console.ReadKey();            
        }
    }
}