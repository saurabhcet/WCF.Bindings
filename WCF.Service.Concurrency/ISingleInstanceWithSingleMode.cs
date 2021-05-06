using System.ServiceModel;

namespace WCF.Service.Concurrency
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISingleInstanceWithSingleMode
    {
        [OperationContract]
        string Get(string client);
        //[OperationContract]
        //string GetSingleInstanceWithSingleConcurreny(string client);

        //[OperationContract]
        //string GetSingleInstanceWithMultipleConcurreny(string client);

        //[OperationContract]
        //string GetSingleInstanceWithReentrantConcurreny(string client);

        //[OperationContract]
        //string GetPerSessionInstanceWithSingleConcurreny(string client);

        //[OperationContract]
        //string GetPerSessionInstanceWithMultipleConcurreny(string client);

        //[OperationContract]
        //string GetPerSessionInstanceWithReentrantConcurreny(string client);

        //[OperationContract]
        //string GetPerCallInstanceWithSingleConcurreny(string client);

        //[OperationContract]
        //string GetPerCallInstanceWithMultipleConcurreny(string client);

        //[OperationContract]
        //string GetPerCallInstanceWithReentrantConcurreny(string client);
    }
}