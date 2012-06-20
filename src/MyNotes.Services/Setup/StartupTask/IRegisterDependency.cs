namespace MyNotes.Services.Setup.StartupTask
{
    using Microsoft.Practices.Unity;

    public interface IRegisterDependency
    {
        void Inject(IUnityContainer container);
    }
}