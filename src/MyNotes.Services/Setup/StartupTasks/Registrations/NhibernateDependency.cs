namespace MyNotes.Services.Setup.StartupTasks.Registrations
{
    using Microsoft.Practices.Unity;
    using log4net;
    using MyNotes.DataStorage.Setup.Database;
    using NHibernate;

    internal class NhibernateDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            var sessionFactory = NhibernateDatabaseContext.Initialize();

            unityContainer.RegisterInstance<ISessionFactory>(sessionFactory, new ContainerControlledLifetimeManager());
        }
    }
}