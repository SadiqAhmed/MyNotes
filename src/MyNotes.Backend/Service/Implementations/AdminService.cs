namespace MyNotes.Backend.Service.Implementations
{
    using System;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using log4net;
    using AutoMapper;
    using NHibernate;
    using Microsoft.Practices.Unity;
    using MyNotes.Backend.Setup.StartupTasks;
    using MyNotes.Backend.Service.Contracts;
    using MyNotes.Backend.Dtos;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.DataAccess.DomainObjects.Repositories;
    using MyNotes.Backend.DataAccess.StorageProxies;
    using System.Collections.Generic;

    internal class AdminService : IAdminService
    {
        ILog _logger;
        ISessionFactory _sessionFactory;

        public AdminService(ILog logger, ISessionFactory sessionFactory)
        {
            _logger = logger;
            _sessionFactory = sessionFactory;
        }

        public IList<GroupDto> GetAllGroups()
        {
            return (new GroupStorageProxy(_sessionFactory)).GetAll();
        }

        public IList<UserDto> GetAllUsers(Guid groupId, bool isSysAccount)
        {
            if(isSysAccount)
                return (new UserStorageProxy(_sessionFactory)).GetAll();
            else
                return (new UserStorageProxy(_sessionFactory)).GetAllInGroup(groupId);
        }

        public MessageResultDto AddGroup(string name)
        {
            return (new GroupStorageProxy(_sessionFactory)).AddGroup(name);
        }

        public MessageResultDto AddUser(string firstname, string lastname, string nickname, string username, string password, Guid groupId)
        {
            return (new UserStorageProxy(_sessionFactory)).AddUser(firstname, lastname, nickname, username, password, groupId);
        }

        public MessageResultDto UpdateGroup(Guid id, string name)
        {
            return (new GroupStorageProxy(_sessionFactory)).UpdateGroup(id, name);
        }

        public MessageResultDto UpdateUser(Guid id, string firstname, string lastname, string nickname, string username, string password, Guid groupId)
        {
            return (new UserStorageProxy(_sessionFactory)).UpdateUser(id, firstname, lastname, nickname, username, password, groupId);
        }
    }
}