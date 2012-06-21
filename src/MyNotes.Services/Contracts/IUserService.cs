namespace MyNotes.Services.Contracts
{
    using System.ServiceModel;
    using MyNotes.Services.Dtos;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserLoginDto UserAuthentication(string username, string password);
    }
}
