namespace MyNotes.Backend.Service.Implementations
{
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

    internal class UserService : IUserService
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
            return (new UserStorageProxy(_sessionFactory)).ValidateUser(username, password);
        }
    }
}
