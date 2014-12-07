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
    public class User : EntityAudit<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
