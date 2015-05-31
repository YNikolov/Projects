﻿using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Http.Formatting;   // testing DateTime converting
using System.Web.Http;
using System.Web.OData.Extensions;

namespace MusicArtists.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors();
            config.AddODataQueryFilter();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.Formatters.Add(new JsonMediaTypeFormatter()); // testing DateTime converting
        }
    }
}