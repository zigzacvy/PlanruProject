using Planru.Core.Domain;
using Planru.Core.Persistence;
using Planru.Plugins.Main.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Main.Persistence.Repositories
{
    public interface IUserRepository : IRepository<User, int>
    {
    }
}
