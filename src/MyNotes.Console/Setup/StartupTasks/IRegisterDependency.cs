namespace MyNotes.Console.Setup.StartupTasks
{
    using Microsoft.Practices.Unity;

    public interface IRegisterDependency
    {
        void Inject(IUnityContainer unityContainer);
    }
}