namespace MvcBase.WebHelper.Mvc
{
    using System.Web.Routing;

    internal class MvcResult : IMvcResult
    {
        public string Action { get; set; }

        public string Controller { get; set; }

        public RouteValueDictionary RouteValueDictionary { get; set; }
    } 
}