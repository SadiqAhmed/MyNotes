namespace MyNotes.Backend.Setup.Database
{
    using NHibernate;

    public interface IDatabaseContext
    {
        ISessionFactory SessionFactory {get; }

        ISession Session { get; }
    }
}
