using Planru.Core.Services;
using Planru.Crosscutting.Adapter;
using Planru.Plugins.Directory.Domain;
using Planru.Plugins.Directory.Persistence.Repositories;
using Planru.Plugins.Directory.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Directory.Services
{
    public class UserService : Service<User, UserDTO, Guid>, IUserService
    {
        public UserService(ITypeAdapter typeAdapter, IUserRepository repository)
            : base(typeAdapter, repository)
        { 

        }
    }
}
