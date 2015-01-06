using Planru.Core.Plugin.WebAPI;
using Planru.Crosscutting.Adapter;
using Planru.Crosscutting.IoC;
using Planru.Plugins.Directory.Domain;
using Planru.Plugins.Directory.Persistence.MongoDB.Repositories;
using Planru.Plugins.Directory.Persistence.Repositories;
using Planru.Plugins.Directory.Services;
using Planru.Plugins.Directory.Services.DTOs;
using Planru.Plugins.Directory.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Directory.WebAPI
{
    public class WebApiConfig : IWebApiConfig
    {
        public void RegisterTypes(IContainer container)
        {
            container.Register<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();
            container.Register<UserController, UserController>();
        }

        public void CreateMappings(ITypeAdapter typeAdapter)
        {
            typeAdapter.CreateMap<User, UserDTO>();
            typeAdapter.CreateMap<UserDTO, User>();
        }
    }
}
