namespace MyNotes.Services.Setup.StartupTasks
{
    using Microsoft.Practices.Unity;

    public interface IIncludeComponent
    {
        void Add();
    }
}