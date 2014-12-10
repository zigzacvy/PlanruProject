using Planru.Core.Plugin.Configuration;
using Planru.Crosscutting.Adapter;
using Planru.Plugins.Directory.Domain;
using Planru.Plugins.Directory.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Directory
{
    public class DirectoryConfigurerAdapter : PluginConfigurerAdapter
    {
        public override void ConfigureMappings(ITypeAdapter typeAdapter)
        {
            typeAdapter.CreateMap<User, UserDTO>();
            typeAdapter.CreateMap<UserDTO, User>();
        }
    }
}
