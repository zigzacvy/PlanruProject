using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Core.Domain;
using Planru.Core.Persistence.MongoDB;

namespace Planru.Plugins.Main.Domain
{
    public class User : MongoEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
