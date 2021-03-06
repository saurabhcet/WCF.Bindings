using System.ServiceModel;
using WCF.Model;

namespace WCF.Service.Loan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEMI
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Transaction PaymentStatus(User user, int amount);
    }
}