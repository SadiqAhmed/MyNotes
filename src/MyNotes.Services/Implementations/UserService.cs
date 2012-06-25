namespace MyNotes.Services.Implementations
{
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using log4net;
    using AutoMapper;
    using NHibernate;
    using Microsoft.Practices.Unity;
    using MyNotes.Services.Setup.StartupTasks;
    using MyNotes.Services.Contracts;
    using MyNotes.Services.Dtos;
    using MyNotes.DataStorage.DomainObjects.Entities;
    using MyNotes.DataStorage.DomainObjects.Repositories;
    using MyNotes.DataStorage.StorageProxies;

    public class UserService : IUserService
    {
        ILog _logger;
        ISessionFactory _sessionFactory;

        public UserService(ILog logger, ISessionFactory sessionFactory)
        {
            _logger = logger;
            _sessionFactory = sessionFactory;
        }

        public string PrintName(string name)
        {
            _logger.Info(string.Format("PrintName was called with parameter - {0}", name));
            return string.Format("Hello world, by {0}", name);
        }

        public UserLoginDto Authenticate(string username, string password)
        {
            var user = (new UserStorageProxy(_sessionFactory)).ValidateUser(username, password);
            return Mapper.Map<UserLoginDto>(user);
        }
    }
}
