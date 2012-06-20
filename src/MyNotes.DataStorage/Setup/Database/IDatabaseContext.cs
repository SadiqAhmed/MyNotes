namespace MyNotes.DataStorage.Setup.Database
{
    using NHibernate;

    public interface IDatabaseContext
    {
        ISessionFactory SessionFactory {get; }

        ISession Session { get; }

        void CreateSessionFactory();
    }
}
