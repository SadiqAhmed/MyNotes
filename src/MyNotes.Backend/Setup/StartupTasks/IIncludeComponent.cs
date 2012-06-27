namespace MyNotes.Backend.Setup.StartupTasks
{
    using Microsoft.Practices.Unity;

    public interface IIncludeComponent
    {
        void Add();
    }
}