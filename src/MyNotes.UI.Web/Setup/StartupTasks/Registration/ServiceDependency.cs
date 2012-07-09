namespace MyNotes.UI.Web.Setup.StartupTasks.Registration
{
    using MvcBase.WebHelper.StartupTasks;
    using Microsoft.Practices.Unity;
    using log4net;
    using MyNotes.UI.Web.EchoServiceRef;
    using MyNotes.UI.Web.UserServiceRef;
    using MyNotes.UI.Web.AdminServiceRef;
    using MyNotes.UI.Web.Setup.ActionApi;

    public class ServiceDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IServiceAction, ServiceAction>();
            unityContainer.RegisterType<IServiceGetAction, ServiceGetAction>();
            unityContainer.RegisterType<IServiceSetAction, ServiceSetAction>();
            unityContainer.RegisterInstance<IAdminService>(new AdminServiceClient());
            unityContainer.RegisterInstance<IEchoService>(new EchoServiceClient());
            unityContainer.RegisterInstance<IUserService>(new UserServiceClient());
        }
    }
}