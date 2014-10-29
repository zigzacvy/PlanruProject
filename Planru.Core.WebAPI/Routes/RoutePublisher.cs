using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Reflection;

namespace Planru.Core.WebAPI.Routes
{
    public class RoutePublisher : IRoutePublisher
    {
        public void RegisterRouters(HttpRouteCollection routeCollection)
        {
            var plugins = Assembly.LoadFrom(@"F:\Projects\Planru\PlanruSystem\Planru.DistributedServices.WebAPI\Plugins\Main\Planru.Plugins.Main.WebAPI.dll");
            var routeProviderTypes = plugins.GetTypes().Where(t => t.GetInterfaces().Any(i => i == typeof(IRouteProvider))).ToList();
            foreach (var providerType in routeProviderTypes)
            {
                var provider = Activator.CreateInstance(providerType) as IRouteProvider;
                provider.RegisterRoutes(routeCollection);
            }
        }
    }
}
