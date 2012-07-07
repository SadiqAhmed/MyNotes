namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;
    using AutoMapper;
    using System.Web.Mvc;
    using MyNotes.UI.Web.Setup.Common;

    public class ServiceGetAction : IServiceGetAction
    {
        public SessionKey _sessionKey;
        private string _contentViewName;
        private object _contentViewModel;
        private string _popupViewName;
        private object _popupViewModel;
        private string _resultViewName;
        private object _resultViewModel;

        public ServiceGetAction(SessionKey sessionKey)
        {
            _sessionKey = sessionKey;
        }

        public IServiceGetAction WithPopup<TViewModel>(string viewName, Func<TViewModel> serviceQuery = null)
        {
            _popupViewName = viewName;

            if (serviceQuery != null)
                _popupViewModel = Mapper.Map<TViewModel>(serviceQuery());

            return (IServiceGetAction)this;
        }

        public IServiceGetAction WithContent<TViewModel>(string viewName, Func<TViewModel> serviceQuery = null)
        {
            _contentViewName = viewName;

            if (serviceQuery != null)
                _contentViewModel = Mapper.Map<TViewModel>(serviceQuery());

            return (IServiceGetAction)this;
        }

        public IServiceGetAction WithResult<TViewModel>(Func<TViewModel> serviceQuery)
        {
            return WithResult<TViewModel>(null, serviceQuery);
        }

        public IServiceGetAction WithResult<TViewModel>(string viewName, Func<TViewModel> serviceQuery = null)
        {
            _resultViewName = viewName;

            if (serviceQuery != null)
                _resultViewModel = Mapper.Map<TViewModel>(serviceQuery());

            return (IServiceGetAction)this;
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