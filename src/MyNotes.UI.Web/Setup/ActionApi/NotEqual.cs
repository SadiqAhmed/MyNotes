﻿namespace MyNotes.UI.Web.Setup.ActionApi
{
    using System;
    using System.Web;
    using System.Web.Routing;

    public class NotEqual : IRouteConstraint
    {
      private string _match = String.Empty;
 
      public NotEqual(string match)
      {
        _match = match;
      }
 
      public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
      {
        return String.Compare(values[parameterName].ToString(), _match, true) != 0;
      }
    }
}