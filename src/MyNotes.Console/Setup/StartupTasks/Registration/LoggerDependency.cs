namespace MyNotes.Console.Setup.StartupTasks.Registration
{
    using Microsoft.Practices.Unity;
    using log4net;

    public class LoggerDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterInstance<ILog>(LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }
    }
}