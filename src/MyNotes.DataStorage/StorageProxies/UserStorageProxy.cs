namespace MyNotes.DataStorage.StorageProxies
{
    using MyNotes.DataStorage.DomainObjects.Entities;
    using NHibernate;
    using MyNotes.DataStorage.DomainObjects.Repositories;

    public class UserStorageProxy
    {
        ISessionFactory _sessionFactory;

        public UserStorageProxy(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public User ValidateUser(string username, string password)
        {
            User user = null;

            using (ISession session = _sessionFactory.OpenSession())
            {
                IRepository<User> userRepository = new Repository<User>(session);
                user = userRepository.FindOne(x => x.Username == username && x.Password == password);
            }

            return user;
        }
    }
}
