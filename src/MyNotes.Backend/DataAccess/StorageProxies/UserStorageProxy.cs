namespace MyNotes.Backend.DataAccess.StorageProxies
{
    using System;
    using AutoMapper;
    using NHibernate;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.DataAccess.DomainObjects.Repositories;
    using MyNotes.Backend.Dtos;
    using System.Collections.Generic;

    internal class UserStorageProxy
    {
        ISessionFactory _sessionFactory;

        public UserStorageProxy(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public LoggedUserInfoDto ValidateUser(string username, string password)
        {
            LoggedUserInfoDto userDto = null;

            using (ISession session = _sessionFactory.OpenSession())
            {
                IRepository<User> userRepository = new Repository<User>(session);
                var user = userRepository.FindOne(x => x.Username == username && x.Password == password);
                userDto = Mapper.Map<LoggedUserInfoDto>(user);
            }

            return userDto;
        }

        public IList<UserDto> GetAllInGroup(Guid groupId)
        {
            IList<UserDto> userDtos = null;

            using (ISession session = _sessionFactory.OpenSession())
            {
                IRepository<User> userRepository = new Repository<User>(session);
                var users = userRepository.FindAll(x => x.Group.Id ==  groupId).List();
                userDtos = Mapper.Map<IList<UserDto>>(users);
            }

            return userDtos;
        }
    }
}
