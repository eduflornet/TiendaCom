using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Configurador.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Para forzar formateo en JSON
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            UnityConfig.RegisterComponents();

            config.EnableCors(); 

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
