namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;

    public interface IServiceGetAction
    {
        IServiceGetAction WithPopup<TViewModel>(string viewName, Func<TViewModel> query = null);

        IServiceGetAction WithContent<TDto, TViewModel>(string viewName, Func<TDto> query = null);

        IServiceGetAction WithResult<TDto, TViewModel>(Func<TDto> query);

        IServiceGetAction WithResult<TDto, TViewModel>(string viewName, Func<TDto> query = null);

        JsonResponseActionResult Execute();
    }
}