namespace MyNotes.UI.Web.Setup.ServerActions
{
    using System;
    using System.Web.Mvc;
    using System.Linq.Expressions;
    using log4net;

    public class ServiceCall<TService> : IServiceCall<TService>
    {
        ILog _logger;
        string _contentViewName;
        object _contentViewModel;
        string _popupViewName;
        object _popupViewModel;
        string _resultViewName;
        object _resultViewModel;
        ActionResult _onSuccessAction;
        ActionResult _onFailureAction;

        public ServiceCall(ILog logger)
        {
            _logger = logger;
        }

        public IServiceCall<TService> WithContent<TViewModel>(string viewname, Func<TViewModel> serviceQuery = null)
        {
            _contentViewName = viewname;

            if (serviceQuery != null)
                _contentViewModel = serviceQuery();

            return this;
        }

        public IServiceCall<TService> WithPopup<TViewModel>(string viewname, Func<TViewModel> serviceQuery = null)
        {
            _popupViewName = viewname;

            if (serviceQuery != null)
                _popupViewModel = serviceQuery();

            return this;
        }

        public IServiceCall<TService> WithResult<TViewModel>(string viewname, Func<TViewModel> serviceQuery = null)
        {
            _resultViewName = viewname;

            if (serviceQuery != null)
                _resultViewModel = serviceQuery();

            return this;
        }

        public IServiceCall<TService> OnSuccess(ActionResult actionResult)
        {
            _onSuccessAction = actionResult;
            return this;
        }

        public IServiceCall<TService> OnFailure(ActionResult actionResult)
        {
            _onFailureAction = actionResult;
            return this;
        }

        public JsonResponseActionResult Execute()
        {
            return new JsonResponseActionResult(
                    new RefreshOptions()
                    {
                        ContentViewName = _contentViewName,
                        ContentViewModel = _contentViewModel,
                        PopupViewName = _popupViewName,
                        PopupViewModel = _popupViewModel,
                        ResultViewName = _resultViewName,
                        ResultViewModel = _resultViewModel,
                    }
                );
        }
    }
}