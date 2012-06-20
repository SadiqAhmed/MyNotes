namespace MyNotes.Console.Setup.StartupTasks.Registration
{
    using Microsoft.Practices.Unity;
    using MyNotes.Console.EchoServiceRef;

    public class ServiceDependency : IRegisterDependency
    {
        public void Inject(IUnityContainer unityContainer)
        {
            unityContainer.RegisterInstance<IEchoService>(new EchoServiceClient());
        }
    }
}