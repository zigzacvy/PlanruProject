using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.WebAPI.Routes
{
    public interface IRouteProvider
    {
        void RegisterRoutes(RouteCollection routes);
        int Priority { get; }
    }
}
