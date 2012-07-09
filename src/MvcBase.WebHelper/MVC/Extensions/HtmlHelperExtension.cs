namespace MvcBase.WebHelper.Mvc.Extensions
{
    using System;
    using System.Web.Mvc;
    using System.Text;
    using System.Web.Routing;
    using MvcBase.WebHelper.Mvc.Extensions;

    public static class HtmlHelperExtension
    {
        public static MvcHtmlString ActionLinkWithFragment(this HtmlHelper htmlHelper, string text, ActionResult fragmentAction, string cssClass = null, string dataOptions = null)
        {
            var mvcActionResult = fragmentAction.AsMVCResult() as IMvcResult;

            if (mvcActionResult == null)
                return null;

            var options = string.Empty;

            var actionLink = string.Format("{0}#{1}",
                        RouteTable.Routes.GetVirtualPathForArea(htmlHelper.ViewContext.RequestContext,
                                                        new RouteValueDictionary(new
                                                        {
                                                            area = string.Empty,
                                                            controller = mvcActionResult.Controller,
                                                            action = string.Empty,
                                                        })).VirtualPath,
                         mvcActionResult.Action);

            if (!string.IsNullOrEmpty(dataOptions))
                options = "data-options=\"" + dataOptions.Trim() + "\"";
            
            return new MvcHtmlString(string.Format("<a id=\"{0}\" href=\"{1}\" class=\"jqAddress {2}\" {3}>{4}</a>", Guid.NewGuid(), actionLink, 
                (string.IsNullOrEmpty(cssClass) ? string.Empty : cssClass.Trim()),
                (string.IsNullOrEmpty(options) ? string.Empty : options.Trim()), text));
        }
    }
}