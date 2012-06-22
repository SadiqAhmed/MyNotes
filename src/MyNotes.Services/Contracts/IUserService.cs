namespace MyNotes.Services.Contracts
{
    using System.ServiceModel;
    using MyNotes.Services.Dtos;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string PrintName(string name);

        [OperationContract]
        UserLoginDto Authenticate(string username, string password);
    }
}
