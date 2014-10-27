using Planru.Core.Persistence;
using Planru.Plugins.Main.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Plugins.Main.Persistence.UnitOfWork;

namespace Planru.Plugins.Main.Persistence.Repositories
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        public UserRepository(DefaultUnitOfWork unitOfWork)
            : base(unitOfWork)
        { 
        }
    }
}
