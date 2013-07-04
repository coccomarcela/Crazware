using System.Web.Http;

namespace ApiTraz
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

         config.Formatters.Remove(config.Formatters.XmlFormatter);
         config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; 
         config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling=Newtonsoft.Json.PreserveReferencesHandling.Objects;
                config.EnableQuerySupport();

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
        

            

          
         
           
          
        }
    }
}
