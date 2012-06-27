namespace MyNotes.UI.Web.Setup.ServerActions
{
    using System;
    using System.Web.Mvc;
    using System.Linq.Expressions;

    public interface IServiceCall
    {
        /// <summary>
        /// This method sets the view name of the action to be returned
        /// </summary>
        /// <param name="viewname">View name</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall WithView(string viewname);

        /// <summary>
        /// This method sets the on success action
        /// </summary>
        /// <param name="actionResult">Action result</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall OnSuccess(ActionResult actionResult);

        /// <summary>
        /// This method sets the on failure action
        /// </summary>
        /// <param name="actionResult">Action result</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall OnFailure(ActionResult actionResult);

        /// <summary>
        /// This method executes the expression
        /// </summary>
        /// <typeparam name="TService">Service of type TService</typeparam>
        /// <param name="expression">TService type</param>
        /// <returns>ActionResult</returns>
        ActionResult Execute<TService>(Expression<Func<TService>> expression);

        /// <summary>
        /// This method executes the expression
        /// </summary>
        /// <typeparam name="TService">Service of type TService</typeparam>
        /// <typeparam name="TReturnType">TService type</typeparam>
        /// <param name="expression">TReturnType type</param>
        /// <returns>ActionResult</returns>
        ActionResult Execute<TService, TReturnType>(Expression<Func<TService, TReturnType>> expression);
    }
}