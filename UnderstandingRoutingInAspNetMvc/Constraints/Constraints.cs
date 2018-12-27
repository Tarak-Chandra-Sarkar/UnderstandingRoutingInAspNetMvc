using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace UnderstandingRoutingInAspNetMvc.Constraints
{
    public class LocalhostConstraints : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.IsLocal;
        }
    }
}