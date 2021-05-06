using System.ServiceModel;

namespace WCF.Service.Concurrency
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPerCallWithReentrantMode" in both code and config file together.
    [ServiceContract]
    public interface IPerCallWithReentrantMode
    {
        [OperationContract(IsOneWay = true)]
        void Get(string client);
    }
}
