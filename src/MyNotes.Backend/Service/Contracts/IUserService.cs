namespace MyNotes.Backend.Service.Contracts
{
    using System;
    using System.ServiceModel;
    using MyNotes.Backend.Dtos;
    using System.Collections.Generic;

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        LoggedUserInfoDto Authenticate(string username, string password);

        [OperationContract]
        IList<GroupDto> GetAllGroups();

        [OperationContract]
        IList<UserDto> GetAllUsers(Guid userId);
    }
}
