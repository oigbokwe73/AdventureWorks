using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AdventureWorks
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.Add(new Route("Edit/{getSpecialOfferID}", new RouteValueDictionary(new { controller = "SpecialOffer", action = "Edit", getSpecialOfferID = UrlParameter.Optional }), new MvcRouteHandler()));
            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}