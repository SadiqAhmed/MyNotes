namespace MyNotes.DataStorage.Setup.Database
{
    using System;
    using System.IO;
    using NHibernate;
    using NHibernate.Tool.hbm2ddl;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using MyNotes.DataStorage.DomainObjects.Entities;

    public class NhibernateDatabaseContext : IDatabaseContext
    {
        private static ISessionFactory _sessionFactory;
        private readonly string _dbFilePath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "_myNotesDatabase.db");

        private NhibernateDatabaseContext()
        {
            CreateSessionFactory();
        }

        public ISessionFactory SessionFactory 
        {
            get { return _sessionFactory ?? (_sessionFactory = (new NhibernateDatabaseContext()).CreateSessionFactory()); }
        }

        public ISession Session
        {
            get { return SessionFactory.OpenSession(); }
        }

        public static ISessionFactory Initialize()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = (new NhibernateDatabaseContext()).CreateSessionFactory();
            }

            return _sessionFactory;
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
