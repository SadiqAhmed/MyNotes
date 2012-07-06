namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using MyNotes.UI.Web.Setup.Common;
    using MyNotes.UI.Web.Setup.Extensions;

    public class ServiceAction : IServiceAction
    {
        private IServiceGetAction _serviceGetAction;
        private IServiceSetAction _serviceSetAction;
        private Controller _controller;

        public ServiceAction(Controller controller)
        {
            _controller = controller;
        }

        public void Initialize(Controller controller, SessionKey sessionKey)
        {
            _controller = controller;
            _controller.Session.RemoveValue(sessionKey);
        }

        public IServiceSetAction Put(SessionKey sessionKey)
        {
            _serviceSetAction = new ServiceSetAction(_controller, sessionKey);
            return _serviceSetAction;
        }

        public IServiceGetAction Fetch(SessionKey sessionKey)
        {
            _serviceGetAction = new ServiceGetAction(sessionKey);
            return _serviceGetAction;
        }
    }
}