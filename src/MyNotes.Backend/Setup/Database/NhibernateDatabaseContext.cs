namespace MyNotes.Backend.Setup.Database
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using NHibernate;
    using NHibernate.Tool.hbm2ddl;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using MyNotes.Backend.DataAccess.DomainObjects.Entities;
    using MyNotes.Backend.DataAccess.DomainObjects.Repositories;

    public class NhibernateDatabaseContext : IDatabaseContext
    {
        private readonly string _dbFilePath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "/SqliteDb/_myNotesDatabase.db");
        private readonly string _groupName = "SysAdmins";

        public NhibernateDatabaseContext()
        {
            SessionFactory = CreateSessionFactory();

            using (ISession session = SessionFactory.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var groupRepository = new Repository<Group>(session);

                var group = groupRepository.FindOne(x => x.Name == _groupName);

                if (group == null)
                {
                    group = new Group
                    {
                        Name = _groupName,
                        IsSysAccount = true,
                    };

                    var user = new User
                    {
                        FirstName = "System",
                        LastName = "Administrator",
                        Username = "admin",
                        Nickname = "SuperAdmin",
                        Password = "@dm1n",
                        Group = group,
                    };

                    groupRepository.Add(group);
                    (new Repository<User>(session)).Add(user);
                    
                    transaction.Commit();
                }
            }
        }

        public ISessionFactory SessionFactory { get; private set; }

        public ISession Session
        {
            get { return SessionFactory.OpenSession(); }
        }

        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(
                SQLiteConfiguration.Standard
                  .UsingFile(_dbFilePath)
              )
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Group>())
              .ExposeConfiguration(config => 
                  {
                      config.SetInterceptor(new AppInterceptor());
                      // delete the existing db on each run
                      if (!File.Exists(_dbFilePath))
                      {
                          // this NHibernate tool takes a configuration (with mapping info in)
                          // and exports a database schema from it
                          new SchemaExport(config)
                            .Create(false, true);
                      }  
                  })
              .BuildSessionFactory();
        }
    }
}
