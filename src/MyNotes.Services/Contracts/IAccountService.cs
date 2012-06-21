namespace MyNotes.Services.Contracts
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        string AddNewAccount();

        [OperationContract]
        string GetAccountById();

        [OperationContract]
        string GetAllAccount();
    }
}
