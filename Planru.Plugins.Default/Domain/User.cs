using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Core.Domain;

namespace Planru.Plugins.Default.Domain
{
    public class User : Entity<User, int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
