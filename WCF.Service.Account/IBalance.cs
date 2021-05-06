using System.ServiceModel;
using WCF.Model;

namespace WCF.Service.Account
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBalance
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        UserAccount Debit(User user, int amount);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        UserAccount Credit(User user, int amount);

        [OperationContract]
        UserAccount AccountDetails(User user);
    }
}