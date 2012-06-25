namespace MyNotes.UI.Web.Setup.StartupTasks.Registration
{
    using MvcBase.WebHelper.StartupTasks;
    using Microsoft.Practices.Unity;
    using log4net;
    using MyNotes.UI.Web.EchoServiceRef;
    using MyNotes.UI.Web.UserServiceRef;

    public class ServiceDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterInstance<IEchoService>(new EchoServiceClient());
            unityContainer.RegisterInstance<IUserService>(new UserServiceClient());
        }
    }
}