namespace MyNotes.Backend.DataAccess.StorageProxies
{
    using AutoMapper;
    using NHibernate;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.DataAccess.DomainObjects.Repositories;
    using MyNotes.Backend.Dtos;
    using System.Collections.Generic;

    internal class GroupStorageProxy
    {
        ISessionFactory _sessionFactory;

        public GroupStorageProxy(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public IList<GroupDto> GetAll()
        {
            IList<GroupDto> groupDtos = null;

            using (ISession session = _sessionFactory.OpenSession())
            {
                IRepository<Group> groupRepository = new Repository<Group>(session);
                var groups = groupRepository.FindAll().List();
                groupDtos = Mapper.Map<IList<GroupDto>>(groups);
            }

            return groupDtos;
        }

        public bool AddGroup(string name)
        {
            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                IRepository<Group> groupRepository = new Repository<Group>(session);
                groupRepository.Add(new Group { Name = name });
                transaction.Commit();
                return true;
            }
            return false;
        }
    }
}
