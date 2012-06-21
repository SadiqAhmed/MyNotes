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
        private readonly string _dbFilePath = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "/Database/_myNotesDatabase.db");

        public NhibernateDatabaseContext()
        {
            SessionFactory = CreateSessionFactory();
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
