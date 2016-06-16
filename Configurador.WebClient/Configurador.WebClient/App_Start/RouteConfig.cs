using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Configurador.WebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
               "",
               new
               {
                   controller = "Componente",
                   action = "List",
                   categoria = (string)null,
                   page = 1
               }
           );
            
        }
    }
}
