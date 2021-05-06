using System;
using WCF.Model;
using WCF.DAL;
using System.ServiceModel;

namespace WCF.Service.Loan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EMI : IEMI
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public Transaction PaymentStatus(User user, int amount)
        {            
            var transaction = new Transaction { UserId = user.UserId, EMIAmount = amount, TransactionNumber = new Guid(), PaymentStatus = true };
            int status = transaction.PaymentStatus ? 1 : 0;

            if (amount > 50)
                throw new Exception("EMI is too high for this payment mode, transaction declined");

            // Save in database
            Database.ExecuteNonQuery(
                $"INSERT dbo.WCF_TRANSACTION([USER_ID], [TRANSACTION_NO], [EMI_AMOUNT], [PAYMENT_STATUS]) " +
                $"VALUES({transaction.UserId}, '{transaction.TransactionNumber}', {transaction.EMIAmount}, {status})");

            Console.WriteLine($"EMI amount of {amount} received");
            return transaction;
        }
    }
}
