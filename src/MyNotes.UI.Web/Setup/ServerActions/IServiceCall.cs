namespace MyNotes.UI.Web.Setup.ServerActions
{
    using System;
    using System.Web.Mvc;
    using System.Linq.Expressions;

    public interface IServiceCall<TService>
    {
        /// <summary>
        /// This method sets the view name of the content
        /// </summary>
        /// <param name="viewname">View name</param>
        /// <param name="serviceAction" ></param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall<TService> WithContent<TViewModel>(string viewname, Func<TViewModel> serviceQuery = null);

        /// <summary>
        /// This method sets the view name of the popup
        /// </summary>
        /// <param name="viewname">View name</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall<TService> WithPopup<TViewModel>(string viewname, Func<TViewModel> serviceQuery = null);

        /// <summary>
        /// This method sets the view name of the result
        /// </summary>
        /// <param name="viewname">View name</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall<TService> WithResult<TViewModel>(string viewname, Func<TViewModel> serviceQuery = null);

        /// <summary>
        /// This method sets the on success action
        /// </summary>
        /// <param name="actionResult">Action result</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall<TService> OnSuccess(ActionResult actionResult);

        /// <summary>
        /// This method sets the on failure action
        /// </summary>
        /// <param name="actionResult">Action result</param>
        /// <returns>IServiceCall type object</returns>
        IServiceCall<TService> OnFailure(ActionResult actionResult);

        /// <summary>
        /// This method executes the expression
        /// </summary>
        /// <returns>JsonResponseActionResult</returns>
        JsonResponseActionResult Execute();
    }
}