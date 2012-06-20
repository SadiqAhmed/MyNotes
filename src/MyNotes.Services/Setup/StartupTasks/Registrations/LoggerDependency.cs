namespace MyNotes.Services.Setup.StartupTasks.Registrations
{
    using Microsoft.Practices.Unity;
    using log4net;

    internal class LoggerDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterInstance<ILog>(LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }
    }
}