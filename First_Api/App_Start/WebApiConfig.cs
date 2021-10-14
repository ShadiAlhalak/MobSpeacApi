﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace First_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name:"MyRoute",
                routeTemplate:"api/{controller}/{action}/{name}/{id}",
                defaults: new {
                    id=RouteParameter.Optional 
                },
                constraints: new {
                  id  = @"\d{0,2}" 
                }
                
            );
        }
    }
}
