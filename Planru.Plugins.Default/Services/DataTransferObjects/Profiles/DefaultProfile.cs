using AutoMapper;
using Planru.Plugins.Default.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Default.Services.DataTransferObjects.Profiles
{
    public class DefaultProfile : Profile
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
