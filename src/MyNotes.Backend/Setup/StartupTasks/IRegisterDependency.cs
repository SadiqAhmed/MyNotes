namespace MyNotes.Backend.Setup.StartupTasks
{
    using Microsoft.Practices.Unity;

    public interface IRegisterDependency
    {
        void Inject(IUnityContainer unityContainer);
    }
}