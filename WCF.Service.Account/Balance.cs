using System;
using WCF.Model;
using WCF.DAL;
using System.ServiceModel;

namespace WCF.Service.Account
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Balance : IBalance
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public UserAccount Credit(User user, int amount)
        {
            int userId = Convert.ToInt32(Database.ExecuteScalar($"SELECT [USER_ID] FROM dbo.WCF_USER WHERE [USER_NAME]='{user.UserName}'"));
            int balance = Convert.ToInt32(Database.ExecuteScalar($"SELECT [ACCOUNT_BALANCE] FROM dbo.WCF_ACCOUNT WHERE [USER_ID]={userId}"));
            int updatedBalance = balance + amount;
            
            // Save in database
            Database.ExecuteNonQuery($"UPDATE dbo.WCF_ACCOUNT SET [ACCOUNT_BALANCE]={updatedBalance} WHERE[USER_ID]={userId}");

            Console.WriteLine($"Existing Balance:{balance}, Updated Balance:{updatedBalance}");
            return new UserAccount { UserId = userId, Balance = updatedBalance };
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public UserAccount Debit(User user, int amount)
        {
            int userId = Convert.ToInt32(Database.ExecuteScalar($"SELECT [USER_ID] FROM dbo.WCF_USER WHERE [USER_NAME]='{user.UserName}'"));
            int balance = Convert.ToInt32(Database.ExecuteScalar($"SELECT [ACCOUNT_BALANCE] FROM dbo.WCF_ACCOUNT WHERE [USER_ID]={userId}"));

            if (amount > balance)
                throw new Exception("Account balance is in-sufficient for this transaction");

            int updatedBalance = balance - amount;

            // Save in database
            Database.ExecuteNonQuery($"UPDATE dbo.WCF_ACCOUNT SET [ACCOUNT_BALANCE]={updatedBalance} WHERE[USER_ID]={userId}");

            Console.WriteLine($"Existing Balance:{balance}, Updated Balance:{updatedBalance}");
            return new UserAccount { UserId = userId, Balance = updatedBalance };
        }

        public UserAccount AccountDetails(User user)
        {
            int userId = Convert.ToInt32(Database.ExecuteScalar($"SELECT [USER_ID] FROM dbo.WCF_USER WHERE [USER_NAME]='{user.UserName}'"));
            int balance = Convert.ToInt32(Database.ExecuteScalar($"SELECT [ACCOUNT_BALANCE] FROM dbo.WCF_ACCOUNT WHERE [USER_ID]={userId}"));

            Console.WriteLine($"Existing Balance:{balance}");
            return new UserAccount { UserId = userId, Balance = balance };
        }
    }
}