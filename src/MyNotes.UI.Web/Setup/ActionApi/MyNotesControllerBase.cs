namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System.Web.Mvc;

    public class MyNotesControllerBase : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

    }
}
