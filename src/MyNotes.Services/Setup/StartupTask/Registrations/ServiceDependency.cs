namespace MyNotes.Services.Setup.StartupTask.Registrations
{
    using Microsoft.Practices.Unity;

    internal class ServiceDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer container)
        {
            container.RegisterType<IService1, Service1>();
            container.RegisterType<IEchoService, EchoService>();
        }
    }
}