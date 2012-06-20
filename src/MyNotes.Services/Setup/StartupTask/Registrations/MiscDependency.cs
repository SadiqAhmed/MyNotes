namespace MyNotes.Services.Setup.StartupTask.Registrations
{
    using Microsoft.Practices.Unity;
    using log4net;

    internal class MiscDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer container)
        {
            container.RegisterInstance<ILog>(LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType));
        }
    }
}