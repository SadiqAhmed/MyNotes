namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System.Web.Mvc;
    using MyNotes.UI.Web.Setup.Common;

    public interface IServiceAction
    {
        void Initialize(Controller controller, SessionKey sessionKey);

        IServiceGetAction Fetch(SessionKey sessionKey);

        IServiceSetAction Put(SessionKey sessionKey);
    }
}