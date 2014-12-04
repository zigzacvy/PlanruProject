using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Core.Domain;
using Planru.Core.Persistence.MongoDB;
using MongoDB.Bson;

namespace Planru.Plugins.Directory.Domain
{
    public interface IUser : IEntity<Guid>
    {

    }
}
