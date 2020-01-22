using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;

namespace HMS
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Set JSON formatter as default one and remove XmlFormatter
            var setting = config.Formatters.JsonFormatter.SerializerSettings;
            setting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            setting.Formatting = Formatting.Indented;
            setting.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.MapHttpAttributeRoutes();

            //var cors = new EnableCorsAttribute("http://localhost:8010", "*", "*");
            var cors = new EnableCorsAttribute("http://localhost:54894", "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}