using Planru.Core.Persistence.MongoDB;
using Planru.Plugins.Directory.Domain;
using Planru.Plugins.Directory.Persistence.MongoDB.Domain;
using Planru.Plugins.Directory.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Directory.Persistence.MongoDB.Repositories
{
    public class UserRepository : Repository<IUser, Guid>, IUserRepository
    {
        public UserRepository()
        {
        }
    }
}
