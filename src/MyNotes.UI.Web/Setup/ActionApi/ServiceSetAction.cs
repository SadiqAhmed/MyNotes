namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;
    using System.Web.Mvc;
    using MyNotes.UI.Web.Setup.Common;
    using MvcBase.WebHelper.Mvc.Extensions;

    public class ServiceSetAction : IServiceSetAction
    {
        private Controller _controller;
        private SessionKey _sessionKey;

        private Func<bool> _serviceCommand;

        private ActionResult _onSuccess;
        private bool _onSuccessIsFragmentAction;
        private ActionResult _onFailure;
        private bool _onFailureIsFragmentAction;
        
        private string _resultViewName;
        private object _resultViewModel;

        public ServiceSetAction(Controller controller, SessionKey sessionKey)
        {
            _controller = controller;
            _sessionKey = sessionKey;
        }

        public IServiceSetAction WithCommand<TEntity>(Func<bool> serviceCommand)
            where TEntity :new()
        {
            _serviceCommand = serviceCommand;
            return (IServiceSetAction)this;
        }

        public IServiceSetAction OnSuccess(ActionResult actionResult, bool isFragmentAtion = true)
        {
            _onSuccess = actionResult;
            _onSuccessIsFragmentAction = isFragmentAtion;
            return (IServiceSetAction)this;
        }

        public IServiceSetAction OnFailure(ActionResult actionResult, bool isFragmentAtion = true)
        {
            _onFailure = actionResult;
            _onFailureIsFragmentAction = isFragmentAtion;
            return (IServiceSetAction)this;
        }

        public JsonResponseActionResult Execute()
        {
            var commandSuccessfull = true;
            string redirectLink = null;

            commandSuccessfull = _serviceCommand();
            
            if (commandSuccessfull && _onSuccess != null)
            {
                redirectLink = (_onSuccessIsFragmentAction ?
                    _controller.Url.UrlWithActionFragment(_onSuccess) :
                    _controller.Url.UrlWithAction(_onSuccess));
            }
            else if(!commandSuccessfull && _onFailure!=null)
            {
                redirectLink = (_onFailureIsFragmentAction ?
                    _controller.Url.UrlWithActionFragment(_onFailure) :
                    _controller.Url.UrlWithAction(_onFailure));
            }
            
            return new JsonResponseActionResult(
                    new RefreshOptions()
                    {
                        ResultViewName = _resultViewName,
                        ResultViewModel = _resultViewModel,
                        RedirectUrl = redirectLink,
                    }
                );
        }
    }
}