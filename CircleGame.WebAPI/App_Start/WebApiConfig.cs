using CircleGame.WebAPI.Attributes;
using System.Web.Http;

namespace CircleGame.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new ApiExceptionAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{count}",
                defaults: new { count = RouteParameter.Optional }
            );
        }
    }
}
