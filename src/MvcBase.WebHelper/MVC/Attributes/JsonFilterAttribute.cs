namespace MvcBase.WebHelper.Mvc.Attributes
{
    using System;
    using System.Web.Mvc;

    public class JsonFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var querystring = filterContext.HttpContext.Request.Form["json"];
            if (querystring != null && Convert.ToBoolean(querystring))
            {
                var result = new JsonResult();
                result.Data = ((ViewResult)filterContext.Result).Model;
                filterContext.Result = result;
            }
            else
                base.OnActionExecuted(filterContext);
        }        
    }
}
