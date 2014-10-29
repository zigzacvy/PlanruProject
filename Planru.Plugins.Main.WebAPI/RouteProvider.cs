using Planru.Core.WebAPI.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Routing;

namespace Planru.Plugins.Main.WebAPI
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "Planru.Plugins.Main.WebAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });    
        }
    }
}
