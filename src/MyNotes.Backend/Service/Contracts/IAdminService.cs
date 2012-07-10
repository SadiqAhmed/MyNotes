namespace MyNotes.Backend.Service.Contracts
{
    using System;
    using System.ServiceModel;
    using MyNotes.Backend.Dtos;
    using System.Collections.Generic;

    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        IList<GroupDto> GetAllGroups();

        [OperationContract]
        IList<UserDto> GetAllUsers(Guid groupId, bool isSysAccount);

        [OperationContract]
        MessageResultDto AddGroup(string name);

        [OperationContract]
        MessageResultDto AddUser(string firstname, string lastname, string nickname, string username, string password, Guid groupId);

        [OperationContract]
        MessageResultDto UpdateGroup(Guid id, string name);

        [OperationContract]
        MessageResultDto UpdateUser(Guid id, string firstname, string lastname, string nickname, string username, string password, Guid groupId);
    }
}
