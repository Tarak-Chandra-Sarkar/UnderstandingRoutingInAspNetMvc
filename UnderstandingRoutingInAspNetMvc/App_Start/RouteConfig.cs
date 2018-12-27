using System.Web.Mvc;
using System.Web.Routing;

namespace UnderstandingRoutingInAspNetMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Product",
                url: "Product/{productId}",
                defaults: new { controller = "Product", action = "Details" },
                constraints: new { productId = @"\d+" }
            );

            routes.MapRoute(
                name: "Blog",                               // Route name
                url: "Archive/{entryDate}",                 // URL with parameters
                defaults: new { controller = "Archive", action = "Entry" }  // Parameter defaults
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
