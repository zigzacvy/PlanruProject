using Planru.Crosscutting.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Plugin.Configuration
{
    public interface IPluginConfigurer 
    {
        void ConfigureMappings(ITypeAdapter typeAdapter);
    }
}
