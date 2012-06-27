namespace MyNotes.Backend.Setup.StartupTasks.Registration
{
    using Microsoft.Practices.Unity;
    using log4net;
    using MyNotes.Backend.DataAccess.DomainObjects.Repositories;

    internal class RepositoryDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}