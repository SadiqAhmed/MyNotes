namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;
    using System.Web.Mvc;

    public interface IServiceSetAction
    {
        IServiceSetAction WithCommand<TEntity>(Func<bool> serviceCommand)
            where TEntity : new();

        IServiceSetAction OnSuccess(ActionResult actionResult, bool isFragmentAtion = true);

        IServiceSetAction OnFailure(ActionResult actionResult, bool isFragmentAtion = true);

        JsonResponseActionResult Execute();
    }
}