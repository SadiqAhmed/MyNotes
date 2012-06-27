namespace MvcBase.WebHelper.MVC.Extensions
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    internal static class ActionResultExtension
    {
        public static IMvcResult AsMVCResult(this ActionResult actionResult)
        {
            IMvcResult mvcResult = new MvcResult();
            var properties = actionResult.GetType().GetProperties();

            if (properties != null)
            {
                mvcResult.Controller = (string)properties.Where(p => p.Name == "Controller").First().GetValue(actionResult, null);
                mvcResult.Action = (string)properties.Where(p => p.Name == "Action").First().GetValue(actionResult, null);
                mvcResult.RouteValueDictionary = (RouteValueDictionary)properties.Where(p => p.Name == "RouteValueDictionary").First().GetValue(actionResult, null);
            }

            return mvcResult;
        }
    } 
}
