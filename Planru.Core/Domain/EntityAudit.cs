using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Domain
{
    public abstract class EntityAudit<TEntity, TID> : Entity<TEntity, TID> 
        where TEntity : EntityAudit<TEntity, TID>
    {
        public DateTime? CreatedDateTime;
        public DateTime? UpdatedDateTime;
    }
}
