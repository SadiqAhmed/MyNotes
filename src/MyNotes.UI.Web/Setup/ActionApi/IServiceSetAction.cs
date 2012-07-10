namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;
    using System.Web.Mvc;
    using MyNotes.UI.Web.AdminServiceRef;

    public interface IServiceSetAction
    {
        IServiceSetAction WithCommand<TEntity>(Func<MessageResultDto> serviceCommand)
            where TEntity : new();

        IServiceSetAction OnSuccess(ActionResult actionResult, bool isFragmentAtion = true);

        IServiceSetAction OnFailure(ActionResult actionResult, bool isFragmentAtion = true);

        JsonResponseActionResult Execute();
    }
}