namespace MyNotes.UI.Web.Setup.ServerActions
{
    using System;
    using System.Web.Mvc;
    using System.Linq.Expressions;
using log4net;

    public class ServiceCall : IServiceCall
    {
        ILog _logger;
        string _viewname;
        ActionResult _onSuccessAction;
        ActionResult _onFailureAction;

        public ServiceCall(ILog logger)
        {
            _logger = logger;
        }

        public IServiceCall WithView(string viewname)
        {
            _viewname = viewname;
            return this;
        }

        public IServiceCall OnSuccess(ActionResult actionResult)
        {
            _onSuccessAction = actionResult;
            return this;
        }

        public IServiceCall OnFailure(ActionResult actionResult)
        {
            _onFailureAction = actionResult;
            return this;
        }

        public ActionResult Execute<TService>(Expression<Func<TService>> expression)
        {
            throw new NotImplementedException();
        }

        public ActionResult Execute<TService, TReturnType>(Expression<Func<TService, TReturnType>> expression)
        {
            throw new NotImplementedException();
            //try
            //{

            //}
            //catch(Exception ex)
            //{
            //    _logger.Error("Error");
            //}
        }
    }
}