namespace MyNotes.Backend.Service.Contracts
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Ping();
    }
}
