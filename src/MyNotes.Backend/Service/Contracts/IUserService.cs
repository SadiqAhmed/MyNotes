namespace MyNotes.Backend.Service.Contracts
{
    using System.ServiceModel;
    using MyNotes.Backend.Dtos;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string PrintName(string name);

        [OperationContract]
        UserLoginDto Authenticate(string username, string password);
    }
}
