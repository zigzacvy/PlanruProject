using AutoMapper;
using Planru.Plugins.Main.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Main.Services.DataTransferObjects.Profiles
{
    public class MainProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<Role, RoleDTO>();
            Mapper.CreateMap<Permission, PermissionDTO>();
            Mapper.CreateMap<Location, LocationDTO>();
        }
    }
}
