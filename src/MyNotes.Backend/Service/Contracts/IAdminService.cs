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
    }
}
