namespace MyNotes.UI.Web.Setup.ServerActions
{
    using System.Web.Mvc;
    using MvcBase.WebHelper.MVC.Extensions;

    public class JsonResponseActionResult : ActionResult
    {
        private RefreshOptions _refreshOptions;

        internal JsonResponseActionResult(RefreshOptions refreshOptions)
        {
            _refreshOptions = refreshOptions;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var ajaxResponse = GetAjaxResponse(context, _refreshOptions.PopupViewName, _refreshOptions.PopupViewModel, _refreshOptions.ContentViewName, _refreshOptions.ContentViewModel, 
                _refreshOptions.ResultViewName, _refreshOptions.ResultViewModel, _refreshOptions.RedirectUrl);

            new JsonResult { Data = ajaxResponse, JsonRequestBehavior = JsonRequestBehavior.AllowGet }.ExecuteResult(context);
        }

        private static AjaxResponse GetAjaxResponse(ControllerContext context, string popupViewName, object popupViewModel, string contentViewName, object contentViewModel, 
            string viewName, object viewModel, string redirectUrl)
        {
            var response = new AjaxResponse();

            if (!string.IsNullOrEmpty(popupViewName))
                response.DataCaptureView = context.RenderPartialViewToString(popupViewName, popupViewModel);

            if (!string.IsNullOrEmpty(contentViewName))
                response.ContentView = context.RenderPartialViewToString(contentViewName, contentViewModel);

            if (!string.IsNullOrEmpty(viewName))
                response.Result = context.RenderPartialViewToString(viewName, viewModel);
            else if(viewModel != null)
            {
            }

            if (!string.IsNullOrEmpty(redirectUrl))
                response.RedirectUrl = redirectUrl;

            return response;
        }
    }
}