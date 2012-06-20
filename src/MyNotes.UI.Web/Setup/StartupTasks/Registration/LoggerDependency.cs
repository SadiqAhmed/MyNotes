namespace MyNotes.UI.Web.Setup.StartupTasks.Registration
{
    using MvcBase.WebHelper.StartupTasks;
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