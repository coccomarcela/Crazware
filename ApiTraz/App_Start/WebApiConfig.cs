using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using ApiTraz.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace ApiTraz
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

         
config.Formatters.Remove(config.Formatters.XmlFormatter);
    config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; 
 config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling=Newtonsoft.Json.PreserveReferencesHandling.Objects;
          //config.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;
            config.EnableQuerySupport();

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional, format = RouteParameter.Optional }
           );
        

            

          
         //   


            //ODataModelBuilder modelBuilder = new ODataModelBuilder();
            //var entitySetConfiguration = modelBuilder.EntitySet<Productores>("Productores");
            //entitySetConfiguration.EntityType.Ignore(t => t.ActProductivas);
            //entitySetConfiguration.EntityType.Ignore(t => t.Apiarios);
            //entitySetConfiguration.EntityType.Ignore(t => t.FormasComercializacion);
            //entitySetConfiguration.EntityType.Ignore(t => t.Grupos);
            //entitySetConfiguration.EntityType.Ignore(t => t.Loc);
            //entitySetConfiguration.EntityType.Ignore(t => t.ManejoColmenar);
            //entitySetConfiguration.EntityType.Ignore(t => t.PlanillaCampo);
            //entitySetConfiguration.EntityType.Ignore(t => t.ProveedoresMatInerte);
            //entitySetConfiguration.EntityType.Ignore(t => t.Remedios);
 
            //var model = modelBuilder.GetEdmModel();
            //config.Routes.MapODataRoute(routeName: "OData", routePrefix: "odata", model: model);

            //config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            //((DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;
         //config.Formatters.Remove(config.Formatters.XmlFormatter);
           // config.Formatters.XmlFormatter.UseXmlSerializer

            //     jsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            //jsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;



            

         // routeTemplate: "api/{controller}/{id}/{format}",
           
          
        }
    }
}
