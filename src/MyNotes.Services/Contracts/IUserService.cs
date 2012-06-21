namespace MyNotes.Services.Contracts
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string PrintName(string name);
    }
}
