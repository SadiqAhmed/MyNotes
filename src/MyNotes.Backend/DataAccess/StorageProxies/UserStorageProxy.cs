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

        public IList<UserDto> GetAll()
        {
            IList<UserDto> userDtos = null;

            using (ISession session = _sessionFactory.OpenSession())
            {
                IRepository<User> userRepository = new Repository<User>(session);
                var users = userRepository.FindAll().List();
                userDtos = Mapper.Map<IList<UserDto>>(users);
            }

            return userDtos;
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

        public MessageResultDto AddUser(string firstname, string lastname, string nickname, string username, string password, Guid groupId)
        {
            var result = new MessageResultDto();

            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                IRepository<Group> groupRepository = new Repository<Group>(session);
                var group = groupRepository.FindOne(x => x.Id == groupId);

                IRepository<User> userRepository = new Repository<User>(session);
                var existingUser = userRepository.FindOne(x => x.Username == username);

                if (null == existingUser)
                {
                    userRepository.Add(new User
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        Nickname = nickname,
                        Username = username,
                        Password = password,
                        Group = group
                    });

                    transaction.Commit();
                }
                else
                {
                    result.ErrorMessage("User with same username already exists");
                }
            }
            return result;
        }

        public MessageResultDto UpdateUser(Guid id, string firstname, string lastname, string nickname, string username, string password, Guid groupId)
        {
            var result = new MessageResultDto();

            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                IRepository<User> userRepository = new Repository<User>(session);
                var user = userRepository.FindOne(x => x.Id == id);

                if (user.Group.Id == groupId)
                {
                    IRepository<Group> groupRepository = new Repository<Group>(session);
                    var group = groupRepository.FindOne(x => x.Id == groupId);
                    user.Group = group;
                }

                user.FirstName = firstname;
                user.LastName = lastname;
                user.Nickname = nickname;
                user.Username = username;
                user.Password = password;

                userRepository.Add(user);

                transaction.Commit();
            }
            return result;
        }
    }
}
