namespace MyNotes.Services.Contracts
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ITransactionService
    {
        [OperationContract]
        string PrintName(string name);
    }
}
