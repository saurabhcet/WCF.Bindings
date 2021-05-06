using System.ServiceModel;

namespace WCF.Service.Concurrency
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPerSessionWithSingleMode" in both code and config file together.
    [ServiceContract]
    public interface IPerSessionWithSingleMode
    {
        [OperationContract]
        string Get(string client);
    }
}
