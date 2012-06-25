namespace MyNotes.Services.Setup.StartupTasks.Registrations
{
    using Microsoft.Practices.Unity;
    using log4net;
    using MyNotes.DataStorage.DomainObjects.Repositories;

    internal class RepositoryDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}