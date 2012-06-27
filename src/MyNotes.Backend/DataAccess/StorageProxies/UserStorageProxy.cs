namespace MyNotes.Backend.DataAccess.StorageProxies
{
    using AutoMapper;
    using NHibernate;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.DataAccess.DomainObjects.Repositories;
    using MyNotes.Backend.Dtos;

    public class UserStorageProxy
    {
        ISessionFactory _sessionFactory;

        public UserStorageProxy(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public UserLoginDto ValidateUser(string username, string password)
        {
            UserLoginDto userDto = null;

            using (ISession session = _sessionFactory.OpenSession())
            {
                IRepository<User> userRepository = new Repository<User>(session);
                var user = userRepository.FindOne(x => x.Username == username && x.Password == password);
                userDto = Mapper.Map<UserLoginDto>(user);
            }

            return userDto;
        }
    }
}
