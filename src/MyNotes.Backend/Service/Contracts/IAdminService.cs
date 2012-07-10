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
        IList<UserDto> GetAllUsers(Guid userId);

        [OperationContract]
        bool AddGroup(string name);

        [OperationContract]
        bool AddUser(string firstname, string lastname, string nickname, string username, string password, Guid groupId);

        [OperationContract]
        bool UpdateGroup(Guid id, string name);

        [OperationContract]
        bool UpdateUser(Guid id, string firstname, string lastname, string nickname, string username, string password, Guid groupId);
    }
}
