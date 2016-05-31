﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Disclosure.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Init",
                url: "",
                defaults: new { controller = "Templates", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Templates", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}