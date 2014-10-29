using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Planru.Core.WebAPI.Routes
{
    public interface IRoutePublisher
    {
        void RegisterRouters(HttpRouteCollection routeCollection);
    }
}
