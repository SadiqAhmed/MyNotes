namespace MyNotes.Backend.Service.Contracts
{
    using System.ServiceModel;
    using MyNotes.Backend.Dtos;
    using System.Collections.Generic;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserLoginDto Authenticate(string username, string password);

        [OperationContract]
        IList<GroupDto> GetAllGroups();
    }
}
