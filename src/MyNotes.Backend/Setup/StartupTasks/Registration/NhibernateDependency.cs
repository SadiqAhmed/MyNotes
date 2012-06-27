namespace MyNotes.Backend.Setup.StartupTasks.Registration
{
    using Microsoft.Practices.Unity;
    using log4net;
    using MyNotes.Backend.Setup.Database;
    using NHibernate;

    internal class NhibernateDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            IDatabaseContext dataContext = new NhibernateDatabaseContext();

            unityContainer.RegisterInstance<ISessionFactory>(dataContext.SessionFactory, new ContainerControlledLifetimeManager());
        }
    }
}