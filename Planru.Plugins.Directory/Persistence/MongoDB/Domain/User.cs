using Planru.Plugins.Directory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Directory.Persistence.MongoDB.Domain
{
    public class User : IUser
    {
        public Guid Id { get; set; }
    }
}
